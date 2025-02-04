//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackdocDbEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class athena_siu_in
    {
        public int id { get; set; }
        public string MSHSendingApplicationName { get; set; }
        public string MSHSendingFacilityEntityIdentifier { get; set; }
        public string MSHSendingFacilityNamespaceID { get; set; }
        public string MSHReceivingApplicationEntityIdentifier { get; set; }
        public string MSHReceivingFacilityEntityIdentifier { get; set; }
        public Nullable<System.DateTime> MSHDateTimeofMessage { get; set; }
        public string MSHMessageTypeType { get; set; }
        public string MSHMessageTypeEvent { get; set; }
        public string MSHMessageControlID { get; set; }
        public string MSHProcessingIDProcessingType { get; set; }
        public string MSHVersionID { get; set; }
        public string SCHPlacerAppointmentIDEntityIdentifier { get; set; }
        public string SCHFillerAppointmentIDEntityIdentifier { get; set; }
        public string SCHEventReasonIdentifier { get; set; }
        public string SCHAppointmentReasonIdentifier { get; set; }
        public string SCHAppointmentTypeIdentifier { get; set; }
        public string SCHAppointmentTypeText { get; set; }
        public Nullable<double> SCHAppointmentDuration { get; set; }
        public string SCHAppointmentDurationUnitsIdentifier { get; set; }
        public Nullable<System.DateTime> SCHAppointmentTimingQuantityStartDatetime { get; set; }
        public string SCHFillerContactPersonIDNumber { get; set; }
        public string SCHFillerStatusCodeIdentifier { get; set; }
        public string PIDPatientIDExternalIDID { get; set; }
        public string PIDPatientIDInternalIDID { get; set; }
        public string PIDPatientNameFamilyName { get; set; }
        public string PIDPatientNameGivenName { get; set; }
        public string PIDPatientNameMiddleInitialorName { get; set; }
        public string PIDPatientNameSuffix { get; set; }
        public Nullable<System.DateTime> PIDDateTimeofBirth { get; set; }
        public string PIDSex { get; set; }
        public string PIDRace { get; set; }
        public string PIDPatientAddressStreetAddress { get; set; }
        public string PIDPatientAddressCity { get; set; }
        public string PIDPatientAddressStateorProvince { get; set; }
        public string PIDPatientAddressZiporpostalcode { get; set; }
        public string PIDPatientAddressCountry { get; set; }
        public string PIDPhoneNumberHomeNumber { get; set; }
        public string PIDPhoneNumberBusinessNumber { get; set; }
        public string PIDPrimaryLanguageIdentifier { get; set; }
        public string PIDPrimaryLanguageText { get; set; }
        public string PIDMaritalStatus { get; set; }
        public string PIDEthnicGroup { get; set; }
        public string PVAssignedPatientLocationPointofCare { get; set; }
        public string PVAssignedPatientLocationRoom { get; set; }
        public string PVAssignedPatientLocationBed { get; set; }
        public string PVAssignedPatientLocationFacilityNamespace { get; set; }
        public string PVAttendingDoctorIDNumber { get; set; }
        public string PVAttendingDoctorFamilyName { get; set; }
        public string PVAdmittingDoctorIDNumber { get; set; }
        public string PVAdmittingDoctorFamilyName { get; set; }
        public string PVVisitNumberID { get; set; }
        public string DGDiagnosisCodingMethod { get; set; }
        public string DGDiagnosisDescription { get; set; }
        public string AIGResourceIDIdentifier { get; set; }
        public Nullable<System.DateTime> AIGStartDateTime { get; set; }
        public Nullable<double> AIGDuration { get; set; }
        public string AIGDurationUnitsIdentifier { get; set; }
        public string AILLocationResourceIDPointofCare { get; set; }
        public string AILLocationResourceIDRoom { get; set; }
        public Nullable<System.DateTime> AILStartDateTime { get; set; }
        public Nullable<double> AILDuration { get; set; }
        public string AILDurationUnitsIdentifier { get; set; }
    }
}
