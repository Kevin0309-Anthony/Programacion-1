﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbuscarcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbuscarcliente))
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.grbBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grbBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_cancel_2467375
        Me.btnCancelarCliente.Location = New System.Drawing.Point(158, 444)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(93, 45)
        Me.btnCancelarCliente.TabIndex = 12
        Me.btnCancelarCliente.UseVisualStyleBackColor = False
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_cursor_309088__1_
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(47, 444)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(78, 45)
        Me.btnSeleccionarCliente.TabIndex = 11
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCliente.Location = New System.Drawing.Point(105, 29)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(632, 20)
        Me.txtBuscarCliente.TabIndex = 10
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Interface_25_2044263
        Me.lblBuscarCliente.Location = New System.Drawing.Point(44, 20)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(55, 43)
        Me.lblBuscarCliente.TabIndex = 9
        '
        'grbBuscarCliente
        '
        Me.grbBuscarCliente.AllowUserToAddRows = False
        Me.grbBuscarCliente.AllowUserToDeleteRows = False
        Me.grbBuscarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcliente, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email})
        Me.grbBuscarCliente.Location = New System.Drawing.Point(47, 69)
        Me.grbBuscarCliente.Name = "grbBuscarCliente"
        Me.grbBuscarCliente.ReadOnly = True
        Me.grbBuscarCliente.RowHeadersWidth = 51
        Me.grbBuscarCliente.Size = New System.Drawing.Size(702, 355)
        Me.grbBuscarCliente.TabIndex = 8
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "ID"
        Me.idcliente.MinimumWidth = 6
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        Me.idcliente.Width = 150
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.MinimumWidth = 6
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 6
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 150
        '
        'frmbuscarcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 532)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnSeleccionarCliente)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.grbBuscarCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmbuscarcliente"
        Me.Text = "Busqueda de Cliente"
        CType(Me.grbBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents grbBuscarCliente As DataGridView
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
