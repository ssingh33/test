﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication

    #Region "Data Workspace"
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public NotInheritable Class DataWorkspace
        Inherits Global.Microsoft.LightSwitch.Framework.Base.DataWorkspace(Of Global.LightSwitchApplication.DataWorkspace, Global.LightSwitchApplication.DataWorkspace.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of a DataWorkspace.  Changes can be made to data sources in the new instance independent of changes made to data sources in the default DataWorkspace.
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub
    
        #End Region
    
        #Region "Public Properties"
    
        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.DataWorkspaceDetails(Of Global.LightSwitchApplication.DataWorkspace, Global.LightSwitchApplication.DataWorkspace.DetailsClass, Global.LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet)
    
            Shared Sub New()
            End Sub
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Properties As Global.LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.DataWorkspacePropertySet(Of Global.LightSwitchApplication.DataWorkspace, Global.LightSwitchApplication.DataWorkspace.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
            End Class
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
            End Class
    
        End Class
    
        #End Region
    
    End Class
    
    #End Region
    
    #Region "Data Services"
    
    #End Region
    
End Namespace
