Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports System.ComponentModel

Namespace HowToSetValidationRulesInCode.Module
    <DefaultClassOptions, DefaultProperty("Subject"), RuleCriteria("RuleCriteria for Incident", DefaultContexts.Save, "AssignedTo is not null", SkipNullOrEmptyValues := False)>
    Public Class Incident
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _assignedTo As Person
        Private _subject As String
        <RuleRequiredField("RuleRequiredField for Incident.Subject", DefaultContexts.Save)>
        Public Property Subject() As String
            Get
                Return _subject
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Subject", _subject, value)
            End Set
        End Property
        Public Property AssignedTo() As Person
            Get
                Return _assignedTo
            End Get
            Set(ByVal value As Person)
                SetPropertyValue("AssignedTo ", _assignedTo, value)
            End Set
        End Property
    End Class


End Namespace
