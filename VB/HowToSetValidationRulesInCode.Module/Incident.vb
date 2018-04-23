Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports System.ComponentModel

Namespace HowToSetValidationRulesInCode.Module
	<DefaultClassOptions, DefaultProperty("Subject"), RuleCriteria("RuleCriteria for Incident", DefaultContexts.Save, "AssignedTo is not null", SkipNullOrEmptyValues := False)> _
	Public Class Incident
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private assignedTo_Renamed As Person
		Private subject_Renamed As String
		<RuleRequiredField("RuleRequiredField for Incident.Subject", DefaultContexts.Save)> _
		Public Property Subject() As String
			Get
				Return subject_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Subject", subject_Renamed, value)
			End Set
		End Property
		Public Property AssignedTo() As Person
			Get
				Return assignedTo_Renamed
			End Get
			Set(ByVal value As Person)
				SetPropertyValue("AssignedTo ", assignedTo_Renamed, value)
			End Set
		End Property
	End Class


End Namespace
