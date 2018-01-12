﻿
Namespace My
    
    'La classe consente la gestione di eventi specifici sulla classe delle impostazioni:
    ' L'evento SettingChanging viene generato prima della modifica di un valore dell'impostazione.
    ' L'evento PropertyChanged viene generato dopo la modifica di un valore dell'impostazione.
    ' L'evento SettingsLoaded viene generato dopo il caricamento dei valori dell'impostazione.
    ' L'evento SettingsSaving viene generato prima del salvataggio dei valori dell'impostazione.
    Partial Friend NotInheritable Class MySettings

     
      Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
         'MsgBox("SettingsLoaded")
      End Sub
   End Class
End Namespace