using System.Net;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

public class PageParser
{
    private string _url;
    private string _directory;
    private string _source;
    private HtmlAgilityPack.HtmlDocument _doc;

    public PageParser(string url, string directory)
    {
        _url = url;
        _directory = directory;
    }

    public void DownloadPage()
    {
        using (WebClient client = new WebClient())
        {
            _source = client.DownloadString(_url);
        }
    }

    public void ParsePage()
    {
        _doc = new HtmlAgilityPack.HtmlDocument();
        _doc.LoadHtml(_source);
    }

    public string GetSource()
    {
        return _source;
    }

    private static readonly HttpClient _httpClient = new HttpClient(new HttpClientHandler
    {
        UseProxy = false,
        UseCookies = false
    });

    public async Task<string> GetViewAsync(string uri)
    {
        return await _httpClient.GetStringAsync(uri);
    }

    public List<string> GetLinks()
    {
        List<string> links = new List<string>();
        try
        {
            foreach (HtmlNode link in _doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string href = _directory + link.Attributes["href"].Value;
                links.Add(href);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error getting links: " + ex.Message);
        }
        return links;
    }

    public List<string> GetCssFiles()
    {
        List<string> cssFiles = new List<string>();
        try
        {
            foreach (HtmlNode css in _doc.DocumentNode.SelectNodes("//link[@rel='stylesheet']"))
            {
                string href = _directory + css.Attributes["href"].Value;
                cssFiles.Add(href);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error getting CSS files: " + ex.Message);
        }
        return cssFiles;
    }

    public List<string> GetJsFiles()
    {
        List<string> jsFiles = new List<string>();
        try
        {
            foreach (HtmlNode js in _doc.DocumentNode.SelectNodes("//script[@src]"))
            {
                string src = _directory + js.Attributes["src"].Value;
                jsFiles.Add(src);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error getting JS files: " + ex.Message);
        }
        return jsFiles;
    }

    public List<string> GetImages()
    {
        List<string> images = new List<string>();
        try
        {
            foreach (HtmlNode img in _doc.DocumentNode.SelectNodes("//img[@src]"))
            {
                string src = _directory + img.Attributes["src"].Value;
                images.Add(src);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error getting images: " + ex.Message);
        }
        return images;
    }
}
