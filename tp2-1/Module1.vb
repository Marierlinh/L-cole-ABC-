Imports System.Data.SqlClient

''' <summary>
''' Module permettant de gerer code réutilisable.
''' 
''' Fait par: Marierlin Higuerey
''' le:
''' modifie le:
''' </summary>
Module Module1
    Public Enum action
        ajout
        modif
        aucune
    End Enum


    'Variables Globales
    Public NoProg As Integer = 0
    Public NoEtudiant As Integer = 0
    Public ActionForm As action = action.aucune


    ''' <summary>
    ''' Procedure permettant de Barrer
    ''' </summary>
    Public Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub


    ''' <summary>
    ''' Procedure permettant de DeBarrer
    ''' </summary>
    Public Sub DeBarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub



End Module
