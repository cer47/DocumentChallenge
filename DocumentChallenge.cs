using System
using System.IO;
namespace DocumentApp {
	class Document {
		static void Main(string[]args){
			//attempt to get and read file//
			try{
				Console.WriteLine("Document");
				Console.WriteLine("Please Give Document Title: ");
				string name=Console.ReadLine();
				string filename=name+".txt";
				string path= Enviornment.CurrentDirectory+"/"+filename;
				if(!File.Exists(path))
				{
					File.WriteAllText(path,content);
				}
				//was successful//
				Console.WriteLine(filename+"was successfully saved. The document contains "+content.Length+" characters");
			}
			//deal with exception//
			catch(Exception E)
			{
				Console.WriteLine(E);
			}
		}
	}
}
			