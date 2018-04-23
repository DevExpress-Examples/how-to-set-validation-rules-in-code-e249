Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports System.ComponentModel '

<DefaultClassOptions(), DefaultProperty("Subject"), _
   RuleCriteria("RuleCriteria for Incident", DefaultContexts.Save, "AssignedTo is not null", _
      "Task should be assigned", SkipNullOrEmptyValues:=False)> _
Public Class Incident
   Inherits BaseObject
   Public Sub New(ByVal session As Session)
      MyBase.New(session)
   End Sub
   Private fAssignedTo As Person
   Private fSubject As String
   <RuleRequiredField("RuleRequiredField for Incident.Subject", DefaultContexts.Save, _
      "A subject must not be empty")> _
   Public Property Subject() As String
      Get
         Return fSubject
      End Get
      Set(ByVal value As String)
         SetPropertyValue("Subject", fSubject, value)
      End Set
   End Property
   Public Property AssignedTo() As Person
      Get
         Return fAssignedTo
      End Get
      Set(ByVal value As Person)
         SetPropertyValue("AssignedTo", fAssignedTo, value)
      End Set
   End Property
End Class
