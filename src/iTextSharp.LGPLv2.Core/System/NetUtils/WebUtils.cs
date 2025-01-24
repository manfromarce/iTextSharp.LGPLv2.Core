#if NET40
using System.Net;
#else
using System.Net.Http;
#endif
using iTextSharp.text;

namespace iTextSharp.LGPLv2.Core.System.NetUtils;

public static class WebUtils
{
    public static Stream GetResponseStream(this Uri url)
    {
        if (url == null)
        {
            throw new ArgumentNullException(nameof(url));
        }

        //CoreFx doesn't support file: or ftp: schemes for WebRequest classes.
        if (url.IsFile)
        {
            return new FileStream(url.LocalPath, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

#if NET40
        var w = WebRequest.Create(url);
        return w.GetResponse().GetResponseStream();
#else
        using (var client = new HttpClient())
        {
            var response = client.GetAsync(url).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }
#endif
    }

    public static Stream GetResponseStream(this string url) => GetResponseStream(Utilities.ToUrl(url));
}