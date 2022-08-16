// Copyright © 2021 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp.Handler
{
    /// <summary>
    /// Class used to handle file downloads.
    /// The methods of this class will called on the CEF UI thread. 
    /// </summary>
    public class DownloadHandler : IDownloadHandler
    {
        /// <inheritdoc />
        bool IDownloadHandler.CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string url, string requestMethod)
        {
            return CanDownload(chromiumWebBrowser, browser, url, requestMethod);
        }

        /// <summary>
        /// Called before a download begins in response to a user-initiated action
        /// (e.g. alt + link click or link click that returns a `Content-Disposition:
        /// attachment` response from the server).
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance</param>
        /// <param name="url">is the target download URL</param>
        /// <param name="requestMethod">is the target method (GET, POST, etc)</param>
        /// <returns>Return true to proceed with the download or false to cancel the download.</returns>
        protected virtual bool CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string url, string requestMethod)
        {
            return true;
        }

        /// <summary>
        /// Called before a download begins.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="callback">Callback interface used to asynchronously continue a download.</param>
        void IDownloadHandler.OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownload(chromiumWebBrowser, browser, downloadItem, callback);
        }

        /// <summary>
        /// Called before a download begins.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="callback">Callback interface used to asynchronously continue a download.</param>
        protected virtual void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {

        }

        /// <summary>
        /// Called when a download's status or progress information has been updated. This may be called multiple times before and after <see cref="OnBeforeDownload"/>.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="callback">The callback used to Cancel/Pause/Resume the process</param>
        void IDownloadHandler.OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdated(chromiumWebBrowser, browser, downloadItem, callback);
        }

        /// <summary>
        /// Called when a download's status or progress information has been updated. This may be called multiple times before and after <see cref="OnBeforeDownload"/>.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="callback">The callback used to Cancel/Pause/Resume the process</param>
        protected virtual void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {

        }
    }
}
