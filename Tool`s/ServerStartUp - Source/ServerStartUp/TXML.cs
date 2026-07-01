using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ServerStartUp
{
	public static class TXML
	{
		public static bool bor_XML_CreateFile(string _FilePath)
		{
			bool result = true;
			try
			{
				if (File.Exists(_FilePath))
				{
					File.SetAttributes(_FilePath, FileAttributes.Normal);
				}
				using (FileStream fileStream = File.Open(_FilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
				{
					fileStream.SetLength(0L);
					XmlTextWriter xmlTextWriter = new XmlTextWriter(fileStream, Encoding.UTF8);
					xmlTextWriter.Formatting = Formatting.Indented;
					xmlTextWriter.WriteStartDocument();
					XmlDocument xmlDocument = new XmlDocument();
					XmlElement xmlElement = xmlDocument.CreateElement("Processes");
					xmlDocument.AppendChild(xmlElement);
					XmlElement xmlElement2 = xmlDocument.CreateElement("Process");
					xmlElement2.SetAttribute("Run", "true");
					xmlElement2.SetAttribute("Delay", "1000");
					xmlElement2.SetAttribute("Path", Environment.SystemDirectory + "\\notepad.exe");
					xmlElement2.SetAttribute("Parameters", "");
					xmlElement.AppendChild(xmlElement2);
					xmlDocument.Save(xmlTextWriter);
					xmlTextWriter.WriteEndDocument();
					xmlTextWriter.Close();
					fileStream.Close();
				}
				File.SetAttributes(_FilePath, FileAttributes.ReadOnly);
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		public static XmlDocument bor_XML_ReadFile(string _FilePath, out string errorDescription)
		{
			XmlDocument xmlDocument = null;
			errorDescription = "";
			try
			{
				xmlDocument = new XmlDocument();
				if (xmlDocument != null)
				{
					if (!string.IsNullOrEmpty(_FilePath) && File.Exists(_FilePath))
					{
						File.SetAttributes(_FilePath, FileAttributes.Normal);
						using (FileStream fileStream = File.Open(_FilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
						{
							xmlDocument.Load(fileStream);
							if (xmlDocument.InnerXml.Length == 0 || !xmlDocument.HasChildNodes)
							{
								xmlDocument = null;
								errorDescription = "XML file is invalid or empty. Configuration won't be loaded.";
							}
						}
						File.SetAttributes(_FilePath, FileAttributes.ReadOnly);
					}
					else
					{
						errorDescription = "The Path to XML file is invalid or file does not exist. Configuration won't be loaded.";
					}
				}
				else
				{
					errorDescription = "Error occurs on creating XML object. Configuration won't be loaded.";
				}
			}
			catch (Exception ex)
			{
				xmlDocument = null;
				errorDescription = ex.Message;
			}
			return xmlDocument;
		}

		public static void bor_XML_Write(string _FilePath, List<bor_FMain.BoR_FileInfo> FileList, out string errorDescription)
		{
			errorDescription = "";
			try
			{
				if (File.Exists(_FilePath))
				{
					File.SetAttributes(_FilePath, FileAttributes.Normal);
				}
				using (FileStream fileStream = File.Open(_FilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
				{
					fileStream.SetLength(0L);
					XmlTextWriter xmlTextWriter = new XmlTextWriter(fileStream, Encoding.UTF8);
					xmlTextWriter.Formatting = Formatting.Indented;
					xmlTextWriter.WriteStartDocument();
					XmlDocument xmlDocument = new XmlDocument();
					XmlElement xmlElement = xmlDocument.CreateElement("Processes");
					xmlDocument.AppendChild(xmlElement);
					for (int i = 0; i < FileList.Count; i++)
					{
						XmlElement xmlElement2 = xmlDocument.CreateElement("Process");
						xmlElement2.SetAttribute("Run", FileList[i].Run.ToString());
						xmlElement2.SetAttribute("Delay", FileList[i].Delay.ToString());
						xmlElement2.SetAttribute("Path", FileList[i].Path);
						xmlElement2.SetAttribute("Parameters", FileList[i].Parameters);
						xmlElement.AppendChild(xmlElement2);
					}
					xmlDocument.Save(xmlTextWriter);
					xmlTextWriter.WriteEndDocument();
					xmlTextWriter.Close();
					fileStream.Close();
				}
				File.SetAttributes(_FilePath, FileAttributes.ReadOnly);
			}
			catch (Exception)
			{
			}
		}
	}
}
