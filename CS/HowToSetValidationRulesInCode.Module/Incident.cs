using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using System.ComponentModel;

namespace HowToSetValidationRulesInCode.Module {
	[DefaultClassOptions]
	[DefaultProperty("Subject")]
	[RuleCriteria("RuleCriteria for Incident", DefaultContexts.Save,  "AssignedTo is not null", SkipNullOrEmptyValues = false)]
	public class Incident : BaseObject {
		public Incident(Session session) : base(session) {
		}
		private Person assignedTo;
		private string subject;
		[RuleRequiredField("RuleRequiredField for Incident.Subject", DefaultContexts.Save)]
		public string Subject {
			get {
				return subject;
			}
			set {
				SetPropertyValue("Subject", ref subject, value);
			}
		}
		public Person AssignedTo {
			get {
				return assignedTo;
			}
			set {
				SetPropertyValue("AssignedTo ", ref assignedTo, value);
			}
		}
	}


}
