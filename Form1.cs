using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Schema;

namespace xmltest {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private const String doc1 = "rules.xml";
		private const String schema = "rules.xsd";
		private XmlValidatingReader xvr = null;
		private XmlTextReader xtr = null;
		private bool m_success;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private TextBox label2;
		private TextBox label3;
		private TextBox txtPrefix;
		private System.ComponentModel.IContainer components;
		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ofd.Multiselect = false;
			ofd.InitialDirectory = Environment.CurrentDirectory;
			urn = label2.Text;
			sname = label3.Text;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.TextBox();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(32, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "LoadTree";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.FullRowSelect = true;
			this.treeView1.Location = new System.Drawing.Point(8, 8);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(288, 264);
			this.treeView1.TabIndex = 3;
			this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(584, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "GetXPathResult";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.Location = new System.Drawing.Point(328, 8);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(352, 264);
			this.listBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(128, 304);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 32);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(456, 280);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "validation";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(304, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "C";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(304, 96);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(16, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "E";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
			this.menuItem1.Text = "&Open";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "&XML";
			this.menuItem3.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "X&SD";
			this.menuItem4.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Location = new System.Drawing.Point(8, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "urn:VisitRuleSchema";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Location = new System.Drawing.Point(165, 280);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "VisitRuleSchema";
			// 
			// txtPrefix
			// 
			this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPrefix.Location = new System.Drawing.Point(328, 282);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(37, 20);
			this.txtPrefix.TabIndex = 12;
			this.txtPrefix.Text = "my:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 340);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "XPath";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			Application.Run(new Form1());
		}
		private bool Validate(String filename, XmlSchemaCollection xsc) {
			m_success = true;

			try {
				xtr = new XmlTextReader(filename);

				//Create a validating reader.
				xvr = new XmlValidatingReader(xtr);

				//Validate using the schemas stored in the schema collection.
				xvr.Schemas.Add(xsc);

				//Set the validation event handler
				xvr.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
				//Read and validate the XML data.
				while (xvr.Read()) {}

				//Close the reader.
				xvr.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}

			return m_success;
		}
		private FileInfo XmlPath = new FileInfo("rules.xml");
		private FileInfo XsdPath = new FileInfo("rules.xsd");
		private string urn;
		private string sname;
		private void button1_Click(object sender, System.EventArgs e) {
			urn = label2.Text.Trim();
			sname = label3.Text.Trim();

			string xdoc = XmlPath.FullName;
			string sdoc = XsdPath.FullName;
			XmlSchemaCollection xsc = new XmlSchemaCollection();
			label1.Text = "IsValid: " + Validate(xdoc, xsc).ToString();
			try {
				xsc.Add(urn, sdoc);
				//			if(Validate(xdoc, xsc)) {
				// SECTION 1. Create a DOM Document and load the XML data into it.
				XmlDocument dom = new XmlDocument();
				dom.Load(xdoc);

				// SECTION 2. Initialize the TreeView control.
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
				TreeNode tNode = new TreeNode();
				tNode = treeView1.Nodes[0];

				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(dom.DocumentElement, tNode);
				treeView1.ExpandAll();
				//			}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode) {
			XmlNode xNode;
			TreeNode tNode;
			XmlNodeList nodeList;
			int i;

			// Loop through the XML nodes until the leaf is reached.
			// Add the nodes to the TreeView during the looping process.
			if (inXmlNode.HasChildNodes) {
				nodeList = inXmlNode.ChildNodes;
				for (i = 0; i <= nodeList.Count - 1; i++) {
					xNode = inXmlNode.ChildNodes[i];
					inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
					tNode = inTreeNode.Nodes[i];
					AddNode(xNode, tNode);
				}
			} else {
				// Here you need to pull the data from the XmlNode based on the
				// type of node, whether attribute values are required, and so forth.
				inTreeNode.Text = (inXmlNode.OuterXml).Trim();
			}
		}
		private void ValidationCallBack(object sender, ValidationEventArgs args) {
			m_success = false;

			MessageBox.Show("\r\n\tValidation error: " + args.Message);
		}
		private void button2_Click(object sender, System.EventArgs e) {
//			DataSet ds = new DataSet();
//			ds.ReadXmlSchema("rules.xsd");
//			ds.ReadXml("rules.xml", XmlReadMode.Auto);
//			dataGrid1.DataSource = ds.Tables[Convert.ToInt32(numericUpDown1.Value)];

//			GetElements("/mtrRules/reversal/userGroups");
			GetElements(textBox1.Text.Trim());
		}
		private void GetElements(string expression) {
////			//Instantiate an XmlDocument object.
////			System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument();
////
////			//Load books.xml into the XmlDocument object.
////			xmldoc.Load("rules.xml");
////
////			//Instantiate an XmlNamespaceManager object.
////			System.Xml.XmlNamespaceManager xmlnsManager = new System.Xml.XmlNamespaceManager(xmldoc.NameTable);
////
////			//Add the namespaces used in books.xml to the XmlNamespaceManager.
////			xmlnsManager.AddNamespace("mr", "urn:rules-schema");
////			
////			System.Xml.XmlNodeList MSPressBookList;
////
////			//Execute the XPath query using the SelectNodes method of the XmlDocument.
////			//Supply the XmlNamespaceManager as the nsmgr parameter.
////			//The matching nodes will be returned as an XmlNodeList.
////			//Use an XmlNode object to iterate through the returned XmlNodeList.
////
////			MSPressBookList = xmldoc.SelectNodes("//../mr:sending", xmlnsManager);
////
////			foreach (System.Xml.XmlNode MSPressBook in MSPressBookList) {
//////				System.Diagnostics.Debug.WriteLine(MSPressBook.InnerText);
////				listBox1.Items.Add(MSPressBook.InnerText);
////
////			}
			string fileName = XmlPath.FullName;
			XPathDocument doc = new XPathDocument(fileName);
			XPathNavigator nav = doc.CreateNavigator();

			// Compile a standard XPath expression
			XPathExpression expr;
			try {
				expr = nav.Compile(expression);
				XmlNamespaceManager context = new XmlNamespaceManager(nav.NameTable);
				context.AddNamespace(txtPrefix.Text.Trim().Substring(0,txtPrefix.Text.Trim().Length-1), urn);
				expr.SetContext(context);
				XPathNodeIterator iterator = nav.Select(expr);

				// Iterate on the node set
				listBox1.Items.Clear();
				label1.Text = Convert.ToString(iterator.Count);
				while (iterator.MoveNext()) {
					XPathNavigator nav2 = iterator.Current.Clone();

					listBox1.Items.Add(nav2.Value);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void button3_Click(object sender, System.EventArgs e) {
			treeView1.CollapseAll();
		}
		private void button4_Click(object sender, System.EventArgs e) {
			treeView1.ExpandAll();
		}
		private void treeView1_DoubleClick(object sender, System.EventArgs e) {
			textBox1.Text =
				treeView1.SelectedNode.FullPath.Replace("\\", String.Format("/{0}", txtPrefix.Text.Trim()));
			textBox1.Text = textBox1.Text.Replace(txtPrefix.Text.Trim()+sname, sname);
			textBox1.Text = textBox1.Text.Replace(txtPrefix.Text.Trim()+"xmlSerializerSection", "xmlSerializerSection");
		}
		private void menuItem1_Click(object sender, System.EventArgs e) {
			ofd.Filter = "XML (*.xml)|*.xml";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				XmlPath = new FileInfo(ofd.FileName);
			}
		}
		private void menuItem2_Click(object sender, System.EventArgs e) {
			ofd.Filter = "XSD (*.xsd)|*.xsd";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				XsdPath = new FileInfo(ofd.FileName);
			}
		}
		private void menuItem5_Click(object sender, System.EventArgs e) {}
	}
}