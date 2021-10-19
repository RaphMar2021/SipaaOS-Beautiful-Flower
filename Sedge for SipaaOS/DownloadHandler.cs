using System;
using System.Windows.Forms;
using Sedge_for_SipaaOS;
using System.IO;
using Guna.UI2.WinForms;

namespace CefSharp.Example.Handlers
{
    public class DownloadHandler : IDownloadHandler
    {
        public static bool LaunchedFromDLHandler;

        public static bool DownloadEnded = true;

        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        NotifyIcon icon = new NotifyIcon();

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }

            if (downloadItem.IsValid)
            {
                DownloadEnded = false;
                //Va afficher des infos sur le fichier que Chromium va télécharger
                //Exemple:
                //== File information =================================
                // File URL: ubuntu.org/ubuntu-lts-2004.iso
                // Suggested FileName: ubuntu-lts-2004.iso
                // MimeType: ISO
                //
                Console.WriteLine("== File information ========================");
                Console.WriteLine(" File URL: {0}", downloadItem.Url);
                Console.WriteLine(" Suggested FileName: {0}", downloadItem.SuggestedFileName);
                Console.WriteLine(" MimeType: {0}", downloadItem.MimeType);
                Console.WriteLine(" Content Disposition: {0}", downloadItem.ContentDisposition);
                Console.WriteLine(" Total Size: {0}", downloadItem.TotalBytes);
                BrowserForm bf = new BrowserForm();
                bf.label2.Text = downloadItem.SuggestedFileName;
                bf.panel1.Visible = true;
                Console.WriteLine("============================================");
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    //Définit le chemin ou Chromium va télécharger le ficier
                    string DownloadsDirectoryPath = "%appdata%\\..\\..\\downloads";

                    callback.Continue(
                        Path.Combine(
                            DownloadsDirectoryPath,
                            downloadItem.SuggestedFileName
                        ),
                        showDialog: false
                    );
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                //Afficher la progression du téléchargement dans la console
                if (downloadItem.IsInProgress && (downloadItem.PercentComplete != 0))
                {
                    Console.WriteLine(
                        "Current Download Speed: {0} bytes ({1}%)",
                        downloadItem.CurrentSpeed,
                        downloadItem.PercentComplete
                    );
                    BrowserForm bf = new BrowserForm();
                    bf.guna2CircleProgressBar1.Maximum = (int)downloadItem.TotalBytes;
                    bf.guna2CircleProgressBar1.Value = (int)downloadItem.ReceivedBytes;
                }

                if (downloadItem.IsComplete)
                {
                    DownloadEnded = true;
                    Console.WriteLine("The download has been finished !");
                }
            }
        }
    }
}
