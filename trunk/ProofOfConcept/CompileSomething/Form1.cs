using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CompileSomething
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string exeName = Path.GetTempFileName() + ".exe";

            string programToCompile = Templates.ClassWithMain.Replace("MAIN_BODY", this.sourceCodeTextBox.Text);

            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.GenerateInMemory = false;
            parameters.IncludeDebugInformation = true;
            parameters.OutputAssembly = exeName;
            //parameters.ReferencedAssemblies.Add( "System.dll" );
            parameters.TreatWarningsAsErrors = true;
            //parameters.WarningLevel = 5;

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, programToCompile);

            errorsBox.Text = string.Empty;

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError error in results.Errors)
                {
                    errorsBox.Text += error.ToString() + Environment.NewLine;
                }
                //MessageBox.Show(results.Errors.Count.ToString() + " errors");
            }
            else
            {
                // actually run it
                Process process = new Process();
                process.StartInfo.FileName = exeName;
                process.Start();
                process.WaitForExit();
            }

            // TODO: clean up temp file?
        }
    }
}
