using System;

public class Download<T> : IDownload where T : Content
{
    private readonly T download;

    public Download(T download)
    {
        this.download = download;
    }

    public bool DownloadContent()
    {
        if (download != null)
        {
            return true;
        }

        return false;
    }
}