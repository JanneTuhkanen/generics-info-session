namespace GenericExample.Examples
{
    public class DropboxFileBrowser
    {
        public void GetDropboxFiles()
        {
            Console.WriteLine("Loading dropbox files");
        }
    }

    public class LocalDriveFileBrowser
    {
        public void GetLocalDriverFiles()
        {
            Console.WriteLine("Loading local drive files");
        }
    }

    internal class FileBrowserService
    {
        private DropboxFileBrowser dropboxFileBrowser = new DropboxFileBrowser();
        private LocalDriveFileBrowser localDriveFileBrowser = new LocalDriveFileBrowser();

        public void Run()
        {
            LoadDropboxFiles();
            LoadLocalDriveFiles();
        }

        public void LoadDropboxFiles()
        {
            dropboxFileBrowser.GetDropboxFiles();
        }

        public void LoadLocalDriveFiles()
        {
            localDriveFileBrowser.GetLocalDriverFiles();
        }
    }
}
