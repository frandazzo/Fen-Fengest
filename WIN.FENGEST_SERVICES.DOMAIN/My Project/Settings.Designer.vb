﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.17929
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funzionalità di salvataggio automatico My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Ds__21.pdf")>  _
        Public Property Ds21_PDF() As String
            Get
                Return CType(Me("Ds21_PDF"),String)
            End Get
            Set
                Me("Ds21_PDF") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Ds__21_old.pdf")>  _
        Public Property Ds21_PDF_OLD() As String
            Get
                Return CType(Me("Ds21_PDF_OLD"),String)
            End Get
            Set
                Me("Ds21_PDF_OLD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Richiesta Assegni per prestazioni.pdf")>  _
        Public Property ASSEGNO_PER_PRESTAZIONI() As String
            Get
                Return CType(Me("ASSEGNO_PER_PRESTAZIONI"),String)
            End Get
            Set
                Me("ASSEGNO_PER_PRESTAZIONI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ANF 42 - INCLUSIONE.pdf")>  _
        Public Property ASSEGGNO_INCLUSIONE() As String
            Get
                Return CType(Me("ASSEGGNO_INCLUSIONE"),String)
            End Get
            Set
                Me("ASSEGGNO_INCLUSIONE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ANFGESTSEP.pdf")>  _
        Public Property ANFGESTSEP() As String
            Get
                Return CType(Me("ANFGESTSEP"),String)
            End Get
            Set
                Me("ANFGESTSEP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ANF_NN.pdf")>  _
        Public Property ASSEGNI_FAMIGLIA_NUMEROSA() As String
            Get
                Return CType(Me("ASSEGNI_FAMIGLIA_NUMEROSA"),String)
            End Get
            Set
                Me("ASSEGNI_FAMIGLIA_NUMEROSA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Richiesta Assegni Familiari per Dipendenti.pdf")>  _
        Public Property ASSEGNO_FAMILIARE() As String
            Get
                Return CType(Me("ASSEGNO_FAMILIARE"),String)
            End Get
            Set
                Me("ASSEGNO_FAMILIARE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Congedo Parentale.pdf")>  _
        Public Property CONGEDO_PARENTALE() As String
            Get
                Return CType(Me("CONGEDO_PARENTALE"),String)
            End Get
            Set
                Me("CONGEDO_PARENTALE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Mod Cure Termali.pdf")>  _
        Public Property CURE_TERMALI() As String
            Get
                Return CType(Me("CURE_TERMALI"),String)
            End Get
            Set
                Me("CURE_TERMALI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dichiarazione di Malattia.pdf")>  _
        Public Property DICHIRAZIONE_MALATTIA() As String
            Get
                Return CType(Me("DICHIRAZIONE_MALATTIA"),String)
            End Get
            Set
                Me("DICHIRAZIONE_MALATTIA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Disoccupazione Requisiti Ridotti.pdf")>  _
        Public Property DISOCCUPAZIONE_REQUISITI_RIDOTTI() As String
            Get
                Return CType(Me("DISOCCUPAZIONE_REQUISITI_RIDOTTI"),String)
            End Get
            Set
                Me("DISOCCUPAZIONE_REQUISITI_RIDOTTI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Maternit… - Stato.pdf")>  _
        Public Property MATERNITA_OBBLIGATORIA() As String
            Get
                Return CType(Me("MATERNITA_OBBLIGATORIA"),String)
            End Get
            Set
                Me("MATERNITA_OBBLIGATORIA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Modello di detrazioni.pdf")>  _
        Public Property MODELLO_DETRAZIONI() As String
            Get
                Return CType(Me("MODELLO_DETRAZIONI"),String)
            End Get
            Set
                Me("MODELLO_DETRAZIONI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MOD.HAND2.pdf")>  _
        Public Property MODELLO_HANDICAP() As String
            Get
                Return CType(Me("MODELLO_HANDICAP"),String)
            End Get
            Set
                Me("MODELLO_HANDICAP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dichiarazione di Permanenza Disoccupazione.pdf")>  _
        Public Property PERMANENZA_DS() As String
            Get
                Return CType(Me("PERMANENZA_DS"),String)
            End Get
            Set
                Me("PERMANENZA_DS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DisoccupazioneOrdinaria-Autocertificazione.pdf")>  _
        Public Property Setting10() As String
            Get
                Return CType(Me("Setting10"),String)
            End Get
            Set
                Me("Setting10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DL86_88bis.pdf")>  _
        Public Property Setting11() As String
            Get
                Return CType(Me("Setting11"),String)
            End Get
            Set
                Me("Setting11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DS22 - Modello Impresa.pdf")>  _
        Public Property Setting12() As String
            Get
                Return CType(Me("Setting12"),String)
            End Get
            Set
                Me("Setting12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ECOCERT.pdf")>  _
        Public Property Setting13() As String
            Get
                Return CType(Me("Setting13"),String)
            End Get
            Set
                Me("Setting13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Modello Hand per maggiorenni.pdf")>  _
        Public Property Setting18() As String
            Get
                Return CType(Me("Setting18"),String)
            End Get
            Set
                Me("Setting18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("O1M SOST.pdf")>  _
        Public Property Setting19() As String
            Get
                Return CType(Me("Setting19"),String)
            End Get
            Set
                Me("Setting19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Assegni 2006.pdf")>  _
        Public Property Setting3() As String
            Get
                Return CType(Me("Setting3"),String)
            End Get
            Set
                Me("Setting3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("CIGS - PAG. DIRETTO.pdf")>  _
        Public Property Setting4() As String
            Get
                Return CType(Me("Setting4"),String)
            End Get
            Set
                Me("Setting4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Delega ModInps.PDF")>  _
        Public Property Setting6() As String
            Get
                Return CType(Me("Setting6"),String)
            End Get
            Set
                Me("Setting6") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WIN.DOMAIN.FED_SERVICES.My.MySettings
            Get
                Return Global.WIN.DOMAIN.FED_SERVICES.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace