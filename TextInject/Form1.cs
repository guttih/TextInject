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
				if (cboFileEncoding.SelectedIndex == 0)
				{
					reader = new StreamReader(fullFileame);

				}
				else
				{
					var enc = cboFileEncoding.SelectedIndex == 1 ? Encoding.UTF8 : Encoding.GetEncoding("ISO-8859-1");
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
			cboFileEncoding.SelectedIndex = 0;
			cboAncor.SelectedIndex = 0;
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
				foreach (string d in Directory.GetDirectories(sDir))
				{
					//todo: allow user to make criteria
					foreach (string f in Directory.GetFiles(d, searchCriteria))
					{
						files.Add(f);

					}
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

		private void inject()
		{/*
			string textToAdd = tb
			string[] files = _files.GetFullFileNames();
			int indexComboAncor = comboAncor.SelectedIndex;
			int indexComboOffset = comboOffset.SelectedIndex;
			int modifedFiles = 0;
			if (files != null)
			{
				foreach (string file in files)
				{
					if (indexComboAncor == 1 && indexComboOffset == 0)
					{
						//user selected "bottom" and "0"
						if (AppendToIsoFile(file, textToAdd))
							modifedFiles++;
					}
					else
					{
						//user selected to use a line offset
						if (AddToFile(file, indexComboAncor == 1, indexComboOffset, textToAdd))
							modifedFiles++;
					}
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
			*/


		}
		private void bInject_Click(object sender, EventArgs e)
		{//\n\n
			int index = cboFileEncoding.SelectedIndex;
			string strEncoding = cboFileEncoding.Items[index].ToString();
			string strMessage;
			if (index == 0)
			{
				strMessage	= "Selected files will be opened\n"
							+ "and the text you typed will be injected to them.";
			}
			else
			{
				strMessage	= "Selected files will be opened with the encoding \"" + strEncoding + "\" \n" 
							+ "and the text you typed will be converted to that format and injected to them.";
			}

			strMessage += "\n\nDo you want to start the injection of these files?";
			var dialogResult = MessageBox.Show(
				strMessage,
				"Starting injection on selected files", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				inject();
				
			}
			else
			{
				MessageBox.Show("°No", "User selected ", MessageBoxButtons.OK);
			}
		}
	}
}
