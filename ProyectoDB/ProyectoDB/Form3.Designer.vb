<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.butNuevo = New System.Windows.Forms.ToolStripButton()
        Me.butGuardar = New System.Windows.Forms.ToolStripButton()
        Me.butEliminar = New System.Windows.Forms.ToolStripButton()
        Me.butCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDatos.Location = New System.Drawing.Point(17, 87)
        Me.dgvDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 28
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(354, 431)
        Me.dgvDatos.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butNuevo, Me.butGuardar, Me.butEliminar, Me.butCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1025, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'butNuevo
        '
        Me.butNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butNuevo.Image = CType(resources.GetObject("butNuevo.Image"), System.Drawing.Image)
        Me.butNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butNuevo.Name = "butNuevo"
        Me.butNuevo.Size = New System.Drawing.Size(29, 24)
        Me.butNuevo.Text = "Nuevo"
        '
        'butGuardar
        '
        Me.butGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butGuardar.Enabled = False
        Me.butGuardar.Image = CType(resources.GetObject("butGuardar.Image"), System.Drawing.Image)
        Me.butGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butGuardar.Name = "butGuardar"
        Me.butGuardar.Size = New System.Drawing.Size(29, 24)
        Me.butGuardar.Text = "Guardar"
        '
        'butEliminar
        '
        Me.butEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butEliminar.Enabled = False
        Me.butEliminar.Image = CType(resources.GetObject("butEliminar.Image"), System.Drawing.Image)
        Me.butEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butEliminar.Name = "butEliminar"
        Me.butEliminar.Size = New System.Drawing.Size(29, 24)
        Me.butEliminar.Text = "Eliminar"
        '
        'butCancelar
        '
        Me.butCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butCancelar.Image = CType(resources.GetObject("butCancelar.Image"), System.Drawing.Image)
        Me.butCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(29, 24)
        Me.butCancelar.Text = "Cancelar"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 529)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents butNuevo As ToolStripButton
    Friend WithEvents butGuardar As ToolStripButton
    Friend WithEvents butEliminar As ToolStripButton
    Friend WithEvents butCancelar As ToolStripButton
End Class
