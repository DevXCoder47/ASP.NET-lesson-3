using ASP.NET_lesson_3_project.ServiceInterfaces;
namespace ASP.NET_lesson_3_project.Services
{
    public class FileService : IFileService
    {
        public List<string> FileNames { get; set; }
        public FileService()
        {
            FileNames = new List<string>();
            FillList();
        }
        public void UploadFile(IFormFile file)
        {
            if (!FileExists(file.FileName))
            {
                FileNames.Add(file.FileName);
                string path = Path.Combine("/Images", file.FileName);
                using Stream stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
            }
        }
        private bool FileExists(string file_name)
        {
            return FileNames.Any(fname => fname == file_name);
        }
        private void FillList()
        {
            DirectoryInfo dir = new DirectoryInfo("wwwroot/Images");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
                FileNames.Add(file.Name);
        }
        public string GetFilesDirectory()
        {
            return "/Images";
        }
    }
}
