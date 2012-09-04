<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(3.0R, 0.0R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 7.5R)
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 0.0R)
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 57.0R)
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblfinal = New System.Windows.Forms.Label()
        Me.lblObjetivo = New System.Windows.Forms.Label()
        Me.lblSolucao = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblPonto2 = New System.Windows.Forms.Label()
        Me.lblPonto1 = New System.Windows.Forms.Label()
        Me.d1f2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.d1f1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.v2f3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.v2f2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.v2f1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.v1f3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.v1f2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.v1f1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Base = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.q1x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.q1x2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.q1F1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.q1F2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.q1b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(949, 507)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblfinal)
        Me.TabPage1.Controls.Add(Me.lblObjetivo)
        Me.TabPage1.Controls.Add(Me.lblSolucao)
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Controls.Add(Me.btnCalc)
        Me.TabPage1.Controls.Add(Me.lblPonto2)
        Me.TabPage1.Controls.Add(Me.lblPonto1)
        Me.TabPage1.Controls.Add(Me.d1f2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.d1f1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.v2f3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.v2f2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.v2f1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.v1f3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.v1f2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.v1f1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(941, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Definições do Problema"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblfinal
        '
        Me.lblfinal.AutoSize = True
        Me.lblfinal.BackColor = System.Drawing.Color.Gainsboro
        Me.lblfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinal.Location = New System.Drawing.Point(156, 438)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(58, 16)
        Me.lblfinal.TabIndex = 25
        Me.lblfinal.Text = "Solução"
        '
        'lblObjetivo
        '
        Me.lblObjetivo.AutoSize = True
        Me.lblObjetivo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblObjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjetivo.Location = New System.Drawing.Point(156, 410)
        Me.lblObjetivo.Name = "lblObjetivo"
        Me.lblObjetivo.Size = New System.Drawing.Size(58, 16)
        Me.lblObjetivo.TabIndex = 24
        Me.lblObjetivo.Text = "Solução"
        '
        'lblSolucao
        '
        Me.lblSolucao.AutoSize = True
        Me.lblSolucao.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolucao.Location = New System.Drawing.Point(156, 381)
        Me.lblSolucao.Name = "lblSolucao"
        Me.lblSolucao.Size = New System.Drawing.Size(58, 16)
        Me.lblSolucao.TabIndex = 23
        Me.lblSolucao.Text = "Solução"
        '
        'Chart1
        '
        ChartArea2.AxisX.Minimum = 0.0R
        ChartArea2.AxisY.Minimum = 0.0R
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(401, 43)
        Me.Chart1.Name = "Chart1"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.Points.Add(DataPoint5)
        Series3.Points.Add(DataPoint6)
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Red
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Series4.Points.Add(DataPoint7)
        Series4.Points.Add(DataPoint8)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(524, 373)
        Me.Chart1.TabIndex = 22
        Me.Chart1.Text = "Chart1"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(298, 263)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 21
        Me.btnCalc.Text = "Calcular"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblPonto2
        '
        Me.lblPonto2.AutoSize = True
        Me.lblPonto2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPonto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPonto2.Location = New System.Drawing.Point(156, 353)
        Me.lblPonto2.Name = "lblPonto2"
        Me.lblPonto2.Size = New System.Drawing.Size(56, 16)
        Me.lblPonto2.TabIndex = 20
        Me.lblPonto2.Text = "Ponto 2:"
        '
        'lblPonto1
        '
        Me.lblPonto1.AutoSize = True
        Me.lblPonto1.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPonto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPonto1.Location = New System.Drawing.Point(156, 326)
        Me.lblPonto1.Name = "lblPonto1"
        Me.lblPonto1.Size = New System.Drawing.Size(56, 16)
        Me.lblPonto1.TabIndex = 19
        Me.lblPonto1.Text = "Ponto 1:"
        '
        'd1f2
        '
        Me.d1f2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.d1f2.Location = New System.Drawing.Point(218, 273)
        Me.d1f2.Name = "d1f2"
        Me.d1f2.Size = New System.Drawing.Size(37, 21)
        Me.d1f2.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(215, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fator 2"
        '
        'd1f1
        '
        Me.d1f1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.d1f1.Location = New System.Drawing.Point(159, 273)
        Me.d1f1.Name = "d1f1"
        Me.d1f1.Size = New System.Drawing.Size(37, 21)
        Me.d1f1.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(156, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fator 1"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(19, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(125, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Disponibilidades"
        '
        'v2f3
        '
        Me.v2f3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v2f3.Location = New System.Drawing.Point(275, 219)
        Me.v2f3.Name = "v2f3"
        Me.v2f3.Size = New System.Drawing.Size(49, 21)
        Me.v2f3.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(272, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "fator Objetivo"
        '
        'v2f2
        '
        Me.v2f2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v2f2.Location = New System.Drawing.Point(218, 219)
        Me.v2f2.Name = "v2f2"
        Me.v2f2.Size = New System.Drawing.Size(37, 21)
        Me.v2f2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(215, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fator 2"
        '
        'v2f1
        '
        Me.v2f1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v2f1.Location = New System.Drawing.Point(159, 219)
        Me.v2f1.Name = "v2f1"
        Me.v2f1.Size = New System.Drawing.Size(37, 21)
        Me.v2f1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(156, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fator 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Variável de Decisão 2"
        '
        'v1f3
        '
        Me.v1f3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v1f3.Location = New System.Drawing.Point(275, 163)
        Me.v1f3.Name = "v1f3"
        Me.v1f3.Size = New System.Drawing.Size(49, 21)
        Me.v1f3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(272, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "fator Objetivo"
        '
        'v1f2
        '
        Me.v1f2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v1f2.Location = New System.Drawing.Point(218, 163)
        Me.v1f2.Name = "v1f2"
        Me.v1f2.Size = New System.Drawing.Size(37, 21)
        Me.v1f2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(215, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fator 2"
        '
        'v1f1
        '
        Me.v1f1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.v1f1.Location = New System.Drawing.Point(159, 163)
        Me.v1f1.Name = "v1f1"
        Me.v1f1.Size = New System.Drawing.Size(37, 21)
        Me.v1f1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(156, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fator 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Variável de Decisão 1"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(941, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solução Método Gráfico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(941, 481)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Solução Método Simplex"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(488, 168)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(304, 144)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 26)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(53, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 26)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(103, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 26)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(153, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 26)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(203, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 26)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(253, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 26)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(53, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 26)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Label21"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Base, Me.q1x1, Me.q1x2, Me.q1F1, Me.q1F2, Me.q1b})
        Me.DataGridView1.Location = New System.Drawing.Point(44, 26)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(371, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Base
        '
        Me.Base.HeaderText = "Base"
        Me.Base.Name = "Base"
        Me.Base.Width = 50
        '
        'q1x1
        '
        Me.q1x1.HeaderText = "x1"
        Me.q1x1.Name = "q1x1"
        Me.q1x1.Width = 50
        '
        'q1x2
        '
        Me.q1x2.HeaderText = "x2"
        Me.q1x2.Name = "q1x2"
        Me.q1x2.Width = 50
        '
        'q1F1
        '
        Me.q1F1.HeaderText = "F1"
        Me.q1F1.Name = "q1F1"
        Me.q1F1.Width = 50
        '
        'q1F2
        '
        Me.q1F2.HeaderText = "F2"
        Me.q1F2.Name = "q1F2"
        Me.q1F2.Width = 50
        '
        'q1b
        '
        Me.q1b.HeaderText = "b"
        Me.q1b.Name = "q1b"
        Me.q1b.Width = 50
        '
        'frmPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPL"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estudo de Programação Linear"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents v1f1 As System.Windows.Forms.TextBox
    Friend WithEvents v1f2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents v1f3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPonto2 As System.Windows.Forms.Label
    Friend WithEvents lblPonto1 As System.Windows.Forms.Label
    Friend WithEvents d1f2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents d1f1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents v2f3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents v2f2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents v2f1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Base As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents q1x1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents q1x2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents q1F1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents q1F2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents q1b As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSolucao As System.Windows.Forms.Label
    Friend WithEvents lblfinal As System.Windows.Forms.Label
    Friend WithEvents lblObjetivo As System.Windows.Forms.Label

End Class
