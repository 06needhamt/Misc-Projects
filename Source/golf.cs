public class Program
{
		static string sourcedir = dir;
        static string destinationdir = dir; 
        static string filetypes = "*.*"; 

	
	public static void Main(string[] args)
	{
		FindFiles();
	}
	public static void FindFiles() 
        {

            foreach (var file in new System.IO.DirectoryInfo(sourcedir).GetFiles(filetypes, System.IO.SearchOption.AllDirectories))
            {
                    file.CopyTo(System.IO.Path.Combine(destinationdir, file.Name)); 
            }
		}
}
