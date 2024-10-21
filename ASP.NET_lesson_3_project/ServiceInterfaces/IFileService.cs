namespace ASP.NET_lesson_3_project.ServiceInterfaces
{
	public interface IFileService
	{
		public List<string> FileNames { get; set; }
		public void UploadFile(IFormFile file);
		public string GetFilesDirectory();
	}
}
