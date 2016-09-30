using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextInject
{
	public partial class Form1 : Form
	{
		private List<string> _files;
		public Form1()
		{
			InitializeComponent();

		}

		private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
		{
			Debug.WriteLine("constructor fired");
		}


		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
		{
			//int x = treeView1.Width;
			//Debug.WriteLine("treeview width : "+ x + "event :" + e.SplitX);
			//tbFolder.Width = treeView1.Width-130;
		}

		private bool viewableFile(string fullFileame)
		{
			string extendion = Path.GetExtension(fullFileame);
			extendion = extendion.ToLower();
			switch (extendion)
			{
				case ".txt":
				case ".sql":
				case ".js":
				case ".c":
				case ".cpp":
				case ".cs":
				case ".cshtml":
				case ".html":

					return true;
			}
			return false;
		}

		private static bool IsValidISO(string input)
		{
			byte[] bytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(input);
			String result = Encoding.GetEncoding("ISO-8859-1").GetString(bytes);
			return String.Equals(input, result);
		}

		private string UTF8_to_ISO_8859_1(string strIso88591)
		{
			Encoding iso = Encoding.GetEncoding("ISO-8859-1");
			Encoding utf8 = Encoding.UTF8;
			byte[] utfBytes = utf8.GetBytes(strIso88591);
			byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
			return iso.GetString(isoBytes);
		}

		private void readFileToTextBox(string fullFileame)
		{
			rtbSelectedFile.Clear();
			if (viewableFile(fullFileame))
			{
				StreamReader reader;
				string str;
				if (comboFileEncoding.SelectedIndex == 0)
				{
					reader = new StreamReader(fullFileame);

				}
				else
				{
					var enc = comboFileEncoding.SelectedIndex == 1 ? Encoding.UTF8 : Encoding.GetEncoding("ISO-8859-1");
					reader = new StreamReader(fullFileame, enc, false);
				}

				str = reader.ReadToEnd();
				reader.Close();
				rtbSelectedFile.Text = str;
			}
			/*
				StreamReader reader = new StreamReader(
					fullFileame,
					Encoding.GetEncoding("ISO-8859-1"),
					false
				);
				string str = reader.ReadToEnd();
				reader.Close();
				if (IsValidISO(str))
					rtbSelectedFile.Text = str;
				else
				{
					reader = new StreamReader(fullFileame);
					str = reader.ReadToEnd();
					reader.Close();
					rtbSelectedFile.Text = str;

			*/



		}

		
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode CurrentNode = e.Node;
			string fullpath = CurrentNode.FullPath;
			readFileToTextBox(fullpath);
		}

		private void tbFolder_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			rtbSelectedFile.Font = new Font(FontFamily.GenericMonospace, rtbSelectedFile.Font.Size);
			comboFileEncoding.SelectedIndex = 0;
			comboAncor.SelectedIndex = 0;
			comboAncor.SelectedIndex = 1; //bottom
			treeView1.Scrollable = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			updateTreeView(true);
		}

		private static void DirSearch(string sDir, List<string> files, string searchCriteria)
		{

			try
			{
				//search current directory
				foreach (string f in Directory.GetFiles(sDir, searchCriteria))
				{
					files.Add(f);

				}
				foreach (string d in Directory.GetDirectories(sDir))
				{
					DirSearch(d, files, searchCriteria);
				}
			}
			catch (System.Exception excpt)
			{
				Console.WriteLine(excpt.Message);
			}
		}

		private static void PopulateTreeView(TreeView treeView, string[] paths, char pathSeparator)
		{
			treeView.Nodes.Clear();
			TreeNode lastNode = null;
			string subPathAgg;
			foreach (string path in paths)
			{
				subPathAgg = string.Empty;
				foreach (string subPath in path.Split(pathSeparator))
				{
					subPathAgg += subPath + pathSeparator;
					TreeNode[] nodes = treeView.Nodes.Find(subPathAgg, true);
					if (nodes.Length == 0)
						if (lastNode == null)
							lastNode = treeView.Nodes.Add(subPathAgg, subPath);
						else
							lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
					else
						lastNode = nodes[0];
					lastNode.Checked = true;
				}
				lastNode = null; // This is the place code was changed

			}
		}

		private void updateTreeView(bool expandAll)
		{

			string dir = lblFolder.Text;
			_files = new List<string>();
			DirSearch(dir, _files, tbSearch.Text);
			PopulateTreeView(treeView1, _files.ToArray(), '\\');
			if (expandAll)
			{
				treeView1.ExpandAll();
			}

		}

		private void tbFolder_DragDrop(object sender, DragEventArgs e)
		{
		}

		private void tbFolder_DragEnter(object sender, DragEventArgs e)
		{
		}

		// Updates all child tree nodes recursively.
		private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
		{
			foreach (TreeNode node in treeNode.Nodes)
			{
				node.Checked = nodeChecked;
				if (node.Nodes.Count > 0)
				{
					// If the current node has child nodes, call the CheckAllChildsNodes method recursively.
					this.CheckAllChildNodes(node, nodeChecked);
				}
			}
		}

		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			// The code only executes if the user caused the checked state to change.
			if (e.Action != TreeViewAction.Unknown)
			{
				if (e.Node.Nodes.Count > 0)
				{
					/* Calls the CheckAllChildNodes method, passing in the current 
					Checked value of the TreeNode whose checked state changed. */
					CheckAllChildNodes(e.Node, e.Node.Checked);
				}
			}
		}

		private void treeView1_Click(object sender, EventArgs e)
		{

		}

		private void treeView1_DragEnter(object sender, DragEventArgs e)
		{
			string[] folders = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			if (folders == null)
				return;
			var attr = File.GetAttributes(folders[0]);
			if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}

		private void treeView1_DragDrop(object sender, DragEventArgs e)
		{
			string[] folder = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			lblFolder.Text = folder[0];
			updateTreeView(true);

		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				updateTreeView(true);
			}
		}

		private void cboFileEncoding_SelectedIndexChanged(object sender, EventArgs e)
		{


			TreeNode currentNode = treeView1.SelectedNode;

			if (currentNode != null)
			{
				readFileToTextBox(currentNode.FullPath);
			}
		}
		
		public void GetCheckedNodes(TreeNodeCollection nodes, List<string> list)
		{
			foreach (System.Windows.Forms.TreeNode aNode in nodes)
			{
				//edit
				string path;
				if (aNode.Checked)
				{
					path = aNode.FullPath;
					if (File.Exists(path))
						list.Add(path);
				}

				if (aNode.Nodes.Count != 0)
					GetCheckedNodes(aNode.Nodes, list);
			}
		}

		private Boolean AppendToFile(string fullFileName, string stringToAppend)
		{
			
			if (stringToAppend.Length < 1)
			{
				return false;//this should not happen, but to be safe.
			}

			if (comboFileEncoding.SelectedIndex == 2)
			{
				stringToAppend = UTF8_to_ISO_8859_1(stringToAppend);
				File.AppendAllText(fullFileName, stringToAppend, Encoding.GetEncoding("ISO-8859-1"));
			}
			else
			{
				File.AppendAllText(fullFileName, stringToAppend);
			}

			return true;
		}


		private bool AddToFile(string fullFileName, bool fromBottom, int inOffset, string stringToAdd)
		{
			int insertIndex;

			if (inOffset < 0 || stringToAdd.Length < 1)
			{
				return false;
			}
			var lineCount = File.ReadLines(fullFileName).Count();
			StreamReader reader;
			if (comboFileEncoding.SelectedIndex == 2)
			{
				stringToAdd = UTF8_to_ISO_8859_1(stringToAdd);
				reader = new StreamReader(	fullFileName,
											Encoding.GetEncoding("ISO-8859-1"),
											false
										 );
			}
			else
			{
				reader = new StreamReader(fullFileName);
			}

			
			if (fromBottom)
			{   //from the bottom
				insertIndex = lineCount - inOffset;
				if (insertIndex < 0)
				{   
					insertIndex = 0;
				}
			}
			else
			{   //from the top
				insertIndex = inOffset +1 ;
				if (insertIndex == lineCount)
				{
					insertIndex++;//to trigger AppendToIsoFile metod
				}
			}

			if (insertIndex > lineCount)
			{
				//  there are no comments in this file so we will or the insertIndex is higer than the number of lines in the file (out of bounds)
				//  We will ignore all indexing and just append comments to the file
				reader.Close();
				return AppendToFile(fullFileName, stringToAdd);
			}


			StreamWriter writer;
			// Let's add the comment at a specific location
			if (comboFileEncoding.SelectedIndex == 2)
			{
				writer = new StreamWriter(	fullFileName + ".temp",
											false,
											Encoding.GetEncoding("ISO-8859-1")
										 );
			}
			else
			{
				writer = new StreamWriter(fullFileName + ".temp");
			}

			string line;
			int counter = 0;
			reader.DiscardBufferedData();
			reader.BaseStream.Seek(0, SeekOrigin.Begin);
			while ((line = reader.ReadLine()) != null)
			{
				counter++;

				if (counter == insertIndex)
				{
					writer.Write(stringToAdd);
				}
				writer.Write(line + "\n");


			}

			reader.Close();
			writer.Close();
			File.Delete(fullFileName);
			File.Move(fullFileName + ".temp", fullFileName);

			return true;
		}

		private void inject()
		{
			List<string> checkedFiles = new List<string>();
			GetCheckedNodes(treeView1.Nodes, checkedFiles);
			string[] files = checkedFiles.ToArray();
			string textToAdd = rtbText.Text;
			int indexComboAncor = comboAncor.SelectedIndex;
			int indexComboOffset;

			int modifedFiles = 0;
			if (files.Length < 1)
			{
				MessageBox.Show("No files selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textToAdd.Length < 1)
			{
				MessageBox.Show("No text to inject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			

			try
			{
				indexComboOffset = Convert.ToInt32(Math.Round(numOffset.Value, 0));
			}
			catch (Exception)
			{
				MessageBox.Show("Line offset has an invalid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (indexComboOffset < 0)
			{
				MessageBox.Show("Line offset cannot be less that zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; //tyo
			}

				foreach (string file in files)
				{
					if (indexComboAncor == 1 && indexComboOffset == 0)
					{
						//user selected "bottom" and "0"
						if (AppendToFile(file, textToAdd))
							modifedFiles++;
					}
					else
					{
						//user selected to use a line offset
						if (AddToFile(file, indexComboAncor == 1, indexComboOffset, textToAdd))
							modifedFiles++;
					}
				}

			if (modifedFiles == 0)
				MessageBox.Show("No files were modified!", "No files modified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				var str = "One file was modified.";
				if (modifedFiles > 1)
					str = "There were " + modifedFiles.ToString() + " files modified.";
				MessageBox.Show(str, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void bInject_Click(object sender, EventArgs e)
		{//\n\n
			int index = comboFileEncoding.SelectedIndex;
			string strEncoding = comboFileEncoding.Items[index].ToString();
			string strMessage;
			if (index == 0)
			{
				strMessage	= "Checked files will be opened\n"
							+ "and the text you typed will be injected to them.";
			}
			else
			{
				strMessage	= "Checked files will be opened with the encoding \"" + strEncoding + "\" \n" 
							+ "and the text you typed will be converted to that format and injected to them.";
			}

			strMessage += "\n\nDo you want to start the injection of these files?";
			var dialogResult = MessageBox.Show(
				strMessage,
				"Starting injection to checked files", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				inject();
				
			}
			
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			About aboutWindow = new About();
			aboutWindow.Show();
		}

		private void browseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// var attr = File.GetAttributes(folders[0]);
			// if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
			

			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Please select the document folder";
			DialogResult result = fbd.ShowDialog();
			try { 
				var attr = File.GetAttributes(fbd.SelectedPath);
				if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
				{
					lblFolder.Text = fbd.SelectedPath;
					updateTreeView(true);
				}
			}
			catch (System.Exception excpt)
			{
				return; // nada
			}

		}

		private void productPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.github.com/guttih/TextInject");
		}
	}
}
