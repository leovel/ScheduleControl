namespace ScheduleControl.Reports
{
    partial class MetadataReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup8 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup9 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.employeeList = new Telerik.Reporting.List();
            this.employeeListPanel = new Telerik.Reporting.Panel();
            this.nomeTextBox = new Telerik.Reporting.TextBox();
            this.detailsTable = new Telerik.Reporting.Table();
            this.Data = new Telerik.Reporting.TextBox();
            this.dataTexBox = new Telerik.Reporting.TextBox();
            this.DiaDaSemana = new Telerik.Reporting.TextBox();
            this.diaTextBox = new Telerik.Reporting.TextBox();
            this.Resultado = new Telerik.Reporting.TextBox();
            this.resultadoTextBox = new Telerik.Reporting.TextBox();
            this.TempoDeTrabalho = new Telerik.Reporting.TextBox();
            this.horasTextBox = new Telerik.Reporting.TextBox();
            this.Saida = new Telerik.Reporting.TextBox();
            this.saidaTextBox = new Telerik.Reporting.TextBox();
            this.Entrada = new Telerik.Reporting.TextBox();
            this.entradaTextBox = new Telerik.Reporting.TextBox();
            this.panel1 = new Telerik.Reporting.Panel();
            this.deptTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.mainDataSource = new Telerik.Reporting.ObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection
            // 
            this.pageHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Mm(25D);
            this.pageHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox9});
            this.pageHeaderSection.Name = "pageHeaderSection";
            this.pageHeaderSection.PrintOnLastPage = false;
            this.pageHeaderSection.Style.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Mm(175D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.employeeList});
            this.detail.Name = "detail";
            // 
            // employeeList
            // 
            this.employeeList.Bindings.Add(new Telerik.Reporting.Binding("DataSource", "= Fields.DataSourse"));
            this.employeeList.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(297D)));
            this.employeeList.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(175D)));
            this.employeeList.Body.SetCellContent(0, 0, this.employeeListPanel);
            tableGroup8.Name = "ColumnGroup";
            this.employeeList.ColumnGroups.Add(tableGroup8);
            this.employeeList.DataSource = null;
            this.employeeList.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.employeeListPanel});
            this.employeeList.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.employeeList.Name = "employeeList";
            tableGroup9.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup9.Name = "DetailGroup";
            this.employeeList.RowGroups.Add(tableGroup9);
            this.employeeList.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(297D), Telerik.Reporting.Drawing.Unit.Mm(175D));
            // 
            // employeeListPanel
            // 
            this.employeeListPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detailsTable,
            this.panel1});
            this.employeeListPanel.Name = "employeeListPanel";
            this.employeeListPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(297D), Telerik.Reporting.Drawing.Unit.Mm(175D));
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchoring = Telerik.Reporting.AnchoringStyles.None;
            this.nomeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(43D), Telerik.Reporting.Drawing.Unit.Mm(2D));
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(203.64D), Telerik.Reporting.Drawing.Unit.Mm(9D));
            this.nomeTextBox.Style.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.nomeTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.nomeTextBox.Value = "= Fields.FullName";
            // 
            // detailsTable
            // 
            this.detailsTable.Anchoring = ((Telerik.Reporting.AnchoringStyles)(((Telerik.Reporting.AnchoringStyles.Top | Telerik.Reporting.AnchoringStyles.Left) 
            | Telerik.Reporting.AnchoringStyles.Right)));
            this.detailsTable.Bindings.Add(new Telerik.Reporting.Binding("DataSource", "= Fields.Details"));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(36.41D)));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(42.87D)));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(30.16D)));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(25.63D)));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(41.39D)));
            this.detailsTable.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(116.55D)));
            this.detailsTable.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(6.09D)));
            this.detailsTable.Body.SetCellContent(0, 0, this.dataTexBox);
            this.detailsTable.Body.SetCellContent(0, 1, this.diaTextBox);
            this.detailsTable.Body.SetCellContent(0, 5, this.resultadoTextBox);
            this.detailsTable.Body.SetCellContent(0, 4, this.horasTextBox);
            this.detailsTable.Body.SetCellContent(0, 3, this.saidaTextBox);
            this.detailsTable.Body.SetCellContent(0, 2, this.entradaTextBox);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.Data;
            tableGroup2.Name = "tableGroup1";
            tableGroup2.ReportItem = this.DiaDaSemana;
            tableGroup3.Name = "group2";
            tableGroup3.ReportItem = this.Entrada;
            tableGroup4.Name = "group1";
            tableGroup4.ReportItem = this.Saida;
            tableGroup5.Name = "group";
            tableGroup5.ReportItem = this.TempoDeTrabalho;
            tableGroup6.Name = "tableGroup2";
            tableGroup6.ReportItem = this.Resultado;
            this.detailsTable.ColumnGroups.Add(tableGroup1);
            this.detailsTable.ColumnGroups.Add(tableGroup2);
            this.detailsTable.ColumnGroups.Add(tableGroup3);
            this.detailsTable.ColumnGroups.Add(tableGroup4);
            this.detailsTable.ColumnGroups.Add(tableGroup5);
            this.detailsTable.ColumnGroups.Add(tableGroup6);
            this.detailsTable.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dataTexBox,
            this.diaTextBox,
            this.resultadoTextBox,
            this.Data,
            this.DiaDaSemana,
            this.Resultado,
            this.TempoDeTrabalho,
            this.horasTextBox,
            this.Saida,
            this.saidaTextBox,
            this.Entrada,
            this.entradaTextBox});
            this.detailsTable.KeepTogether = true;
            this.detailsTable.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(1.99D), Telerik.Reporting.Drawing.Unit.Mm(23D));
            this.detailsTable.Name = "detailsTable";
            tableGroup7.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup7.Name = "detailTableGroup";
            this.detailsTable.RowGroups.Add(tableGroup7);
            this.detailsTable.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(293.01D), Telerik.Reporting.Drawing.Unit.Mm(12.17D));
            this.detailsTable.StyleName = "";
            // 
            // Data
            // 
            this.Data.Name = "Data";
            this.Data.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(36.41D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.Data.Style.Font.Bold = true;
            this.Data.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.Data.Value = "Data";
            // 
            // dataTexBox
            // 
            this.dataTexBox.Name = "dataTexBox";
            this.dataTexBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(36.41D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.dataTexBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.dataTexBox.Value = "= Format(\"{0:dd/MM/yy}\", Fields.Date)";
            // 
            // DiaDaSemana
            // 
            this.DiaDaSemana.Name = "DiaDaSemana";
            this.DiaDaSemana.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(42.87D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.DiaDaSemana.Style.Font.Bold = true;
            this.DiaDaSemana.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.DiaDaSemana.Value = "Dia da Semana";
            // 
            // diaTextBox
            // 
            this.diaTextBox.Name = "diaTextBox";
            this.diaTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(42.87D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.diaTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.diaTextBox.Value = "= Fields.DayStr";
            // 
            // Resultado
            // 
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(116.55D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.Resultado.Style.Font.Bold = true;
            this.Resultado.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.Resultado.Value = "Resultado";
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(116.55D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.resultadoTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.resultadoTextBox.Value = "= Fields.Status";
            // 
            // TempoDeTrabalho
            // 
            this.TempoDeTrabalho.Name = "TempoDeTrabalho";
            this.TempoDeTrabalho.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(41.39D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.TempoDeTrabalho.Style.Font.Bold = true;
            this.TempoDeTrabalho.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.TempoDeTrabalho.StyleName = "";
            this.TempoDeTrabalho.Value = "Tempo de Trabalho";
            // 
            // horasTextBox
            // 
            this.horasTextBox.Name = "horasTextBox";
            this.horasTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(41.39D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.horasTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.horasTextBox.StyleName = "";
            this.horasTextBox.Value = "= Fields.ServiceTime";
            // 
            // Saida
            // 
            this.Saida.Name = "Saida";
            this.Saida.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(25.63D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.Saida.Style.Font.Bold = true;
            this.Saida.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.Saida.StyleName = "";
            this.Saida.Value = "Saída";
            // 
            // saidaTextBox
            // 
            this.saidaTextBox.Name = "saidaTextBox";
            this.saidaTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(25.63D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.saidaTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.saidaTextBox.StyleName = "";
            this.saidaTextBox.Value = "= Fields.ClockOut";
            // 
            // Entrada
            // 
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30.16D), Telerik.Reporting.Drawing.Unit.Mm(6.08D));
            this.Entrada.Style.Font.Bold = true;
            this.Entrada.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.Entrada.StyleName = "";
            this.Entrada.Value = "Entrada";
            // 
            // entradaTextBox
            // 
            this.entradaTextBox.Name = "entradaTextBox";
            this.entradaTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30.16D), Telerik.Reporting.Drawing.Unit.Mm(6.09D));
            this.entradaTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.entradaTextBox.StyleName = "";
            this.entradaTextBox.Value = "= Fields.ClockIn";
            // 
            // panel1
            // 
            this.panel1.Anchoring = ((Telerik.Reporting.AnchoringStyles)(((Telerik.Reporting.AnchoringStyles.Top | Telerik.Reporting.AnchoringStyles.Left) 
            | Telerik.Reporting.AnchoringStyles.Right)));
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nomeTextBox,
            this.deptTextBox,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(293D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.panel1.Style.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(43D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(66.44D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            this.deptTextBox.Style.Color = System.Drawing.Color.SteelBlue;
            this.deptTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.deptTextBox.Value = "= Fields.Department";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(184.64D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(62D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            this.textBox1.Style.Color = System.Drawing.Color.SteelBlue;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox1.Value = "= Fields.ServiceTimeDesc";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(3D), Telerik.Reporting.Drawing.Unit.Mm(2D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(40D), Telerik.Reporting.Drawing.Unit.Mm(9D));
            this.textBox2.Style.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox2.Value = "Funcionário:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(3D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(40D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            this.textBox3.Style.Color = System.Drawing.Color.SteelBlue;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox3.Value = "Departamento:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(135.07D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(49.57D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            this.textBox4.Style.Color = System.Drawing.Color.SteelBlue;
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox4.Value = "Horas de Trabalho:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(65D), Telerik.Reporting.Drawing.Unit.Mm(2D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(167D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.textBox5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.Style.Font.Name = "Copperplate Gothic Bold";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(26D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "RELATÓRIO DE EFECTIVIDADE";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(94D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(32.44D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.textBox6.Style.Color = System.Drawing.Color.DimGray;
            this.textBox6.Style.Font.Name = "Britannic Bold";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "PERÍODO:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(126.44D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(33D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.textBox7.Style.Color = System.Drawing.Color.DimGray;
            this.textBox7.Style.Font.Name = "Britannic Bold";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "= Format(\"{0:dd/MM/yy}\", Fields.BeginDate)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(163.45D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(39D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.textBox8.Style.Color = System.Drawing.Color.DimGray;
            this.textBox8.Style.Font.Name = "Britannic Bold";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "= Format(\"{0:dd/MM/yy}\", Fields.EndDate)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(159.44D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(4D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.textBox9.Style.Color = System.Drawing.Color.DimGray;
            this.textBox9.Style.Font.Name = "Britannic Bold";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "-";
            // 
            // mainDataSource
            // 
            this.mainDataSource.DataSource = typeof(ScheduleControl.ViewModels.MetadataViewModel);
            this.mainDataSource.Name = "mainDataSource";
            // 
            // MetadataReport
            // 
            this.DataSource = this.mainDataSource;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection,
            this.detail});
            this.Name = "MetadataReport";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(297D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.ObjectDataSource mainDataSource;
        private Telerik.Reporting.List employeeList;
        private Telerik.Reporting.Panel employeeListPanel;
        private Telerik.Reporting.TextBox nomeTextBox;
        private Telerik.Reporting.Table detailsTable;
        private Telerik.Reporting.TextBox dataTexBox;
        private Telerik.Reporting.TextBox diaTextBox;
        private Telerik.Reporting.TextBox resultadoTextBox;
        private Telerik.Reporting.TextBox horasTextBox;
        private Telerik.Reporting.TextBox saidaTextBox;
        private Telerik.Reporting.TextBox entradaTextBox;
        private Telerik.Reporting.TextBox Data;
        private Telerik.Reporting.TextBox DiaDaSemana;
        private Telerik.Reporting.TextBox Entrada;
        private Telerik.Reporting.TextBox Saida;
        private Telerik.Reporting.TextBox TempoDeTrabalho;
        private Telerik.Reporting.TextBox Resultado;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.TextBox deptTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
    }
}