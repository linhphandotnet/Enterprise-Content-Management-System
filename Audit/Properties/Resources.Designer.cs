﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecm.Audit {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ecm.Audit.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MM/dd/yyyy hh:mm:ss tt.
        /// </summary>
        internal static string DateTimeFormat {
            get {
                return ResourceManager.GetString("DateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; delete on docs: &apos;{1}&apos;.
        /// </summary>
        internal static string logDeleteDocument {
            get {
                return ResourceManager.GetString("logDeleteDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; email on docs: &apos;{1}&apos;.
        /// </summary>
        internal static string logEmailDocument {
            get {
                return ResourceManager.GetString("logEmailDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; exports index data on docs: &apos;{1}&apos;.
        /// </summary>
        internal static string logExportIndexData {
            get {
                return ResourceManager.GetString("logExportIndexData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; changes index values on doc &apos;{1}&apos; as follow: {2}.
        /// </summary>
        internal static string logModifyIndex {
            get {
                return ResourceManager.GetString("logModifyIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; print on docs: &apos;{1}&apos;.
        /// </summary>
        internal static string logPrintDocument {
            get {
                return ResourceManager.GetString("logPrintDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Repository successfully..
        /// </summary>
        internal static string logUpdateRepository {
            get {
                return ResourceManager.GetString("logUpdateRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MM/dd/yyyy hh:mm tt.
        /// </summary>
        internal static string LongDateTimeFormat {
            get {
                return ResourceManager.GetString("LongDateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 9999-12-31.
        /// </summary>
        internal static string MaxDate {
            get {
                return ResourceManager.GetString("MaxDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1753-1-1.
        /// </summary>
        internal static string MinDate {
            get {
                return ResourceManager.GetString("MinDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MM/dd/yyyy.
        /// </summary>
        internal static string ShortDateTimeFormat {
            get {
                return ResourceManager.GetString("ShortDateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h:mm:ss tt.
        /// </summary>
        internal static string TimeFormat {
            get {
                return ResourceManager.GetString("TimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning:  This computer program is protected by copyright law and international treaties. Unauthorized reproduction or distribution of this program, or any portion of it, may result in severe criminal penalties, and will be prosecuted to the maximum extent possible under the law..
        /// </summary>
        internal static string uiAboutText {
            get {
                return ResourceManager.GetString("uiAboutText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied..
        /// </summary>
        internal static string uiAccessDenied {
            get {
                return ResourceManager.GetString("uiAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application name is already existed..
        /// </summary>
        internal static string uiApplicationExisted {
            get {
                return ResourceManager.GetString("uiApplicationExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully refreshed data..
        /// </summary>
        internal static string uiCacheDataRefreshSuccessful {
            get {
                return ResourceManager.GetString("uiCacheDataRefreshSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the index field is modified or deleted, other options may become invalid, including DB Lookup and Import. If Continue, be sure to update these options with the modification. Would you like to continue?.
        /// </summary>
        internal static string uiChangeIndexFieldConfirmation {
            get {
                return ResourceManager.GetString("uiChangeIndexFieldConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password changed unsuccessfully. Please try again..
        /// </summary>
        internal static string uiChangePasswordFailed {
            get {
                return ResourceManager.GetString("uiChangePasswordFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save changes to the following item(s)?.
        /// </summary>
        internal static string uiCloseTabConfirmation {
            get {
                return ResourceManager.GetString("uiCloseTabConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the selection(s)?.
        /// </summary>
        internal static string uiConfirmDelete {
            get {
                return ResourceManager.GetString("uiConfirmDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t connect to server. Please contact administrator for support..
        /// </summary>
        internal static string uiConnectFail {
            get {
                return ResourceManager.GetString("uiConnectFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All rights reserved..
        /// </summary>
        internal static string uiCopyright {
            get {
                return ResourceManager.GetString("uiCopyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright © {0}.
        /// </summary>
        internal static string uiCopyrightWithYear {
            get {
                return ResourceManager.GetString("uiCopyrightWithYear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data is invalid. Please check..
        /// </summary>
        internal static string uiDataInvalid {
            get {
                return ResourceManager.GetString("uiDataInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ILINX Content Store.
        /// </summary>
        internal static string uiDefaultWebFeedText {
            get {
                return ResourceManager.GetString("uiDefaultWebFeedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the index field is modified or deleted, other options may become invalid, including DB Lookup and Import. If Continue, be sure to update these options with the modification. Would you like to continue?.
        /// </summary>
        internal static string uiDeleteIndexFieldConfirmation {
            get {
                return ResourceManager.GetString("uiDeleteIndexFieldConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanner error. The device driver might not be installed or it might not be installed correctly..
        /// </summary>
        internal static string uiDeviceNotFound {
            get {
                return ResourceManager.GetString("uiDeviceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document with Id = {0} does not exist in the system..
        /// </summary>
        internal static string uiDocumentDoesNotExist {
            get {
                return ResourceManager.GetString("uiDocumentDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid {0} value for {1}..
        /// </summary>
        internal static string uiEnterValidValue {
            get {
                return ResourceManager.GetString("uiEnterValidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field name is already existed..
        /// </summary>
        internal static string uiFieldNameExisted {
            get {
                return ResourceManager.GetString("uiFieldNameExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a required field.
        /// </summary>
        internal static string uiFieldRequired {
            get {
                return ResourceManager.GetString("uiFieldRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected folder not found..
        /// </summary>
        internal static string uiFolderNotFound {
            get {
                return ResourceManager.GetString("uiFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error has occurred. Please contact your administrator for support..
        /// </summary>
        internal static string uiGeneralError {
            get {
                return ResourceManager.GetString("uiGeneralError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import document completed..
        /// </summary>
        internal static string uiImportDocumentCompleted {
            get {
                return ResourceManager.GetString("uiImportDocumentCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data is invalid on the following items:.
        /// </summary>
        internal static string uiIndexValueInvalid {
            get {
                return ResourceManager.GetString("uiIndexValueInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid date is between 1/1/1753 and 12/31/9999.
        /// </summary>
        internal static string uiInvalidDateMessage {
            get {
                return ResourceManager.GetString("uiInvalidDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} value must be less than {1}..
        /// </summary>
        internal static string uiInvalidMaxValue {
            get {
                return ResourceManager.GetString("uiInvalidMaxValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} value must be greater than {1}..
        /// </summary>
        internal static string uiInvalidMinValue {
            get {
                return ResourceManager.GetString("uiInvalidMinValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} value must be less than {1} and greater than {2}..
        /// </summary>
        internal static string uiInvalueValueRange {
            get {
                return ResourceManager.GetString("uiInvalueValueRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The User name or Password is incorrect. Please try again..
        /// </summary>
        internal static string uiLoginFail {
            get {
                return ResourceManager.GetString("uiLoginFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required field “{0}” must be mapped..
        /// </summary>
        internal static string uiMappingRequired {
            get {
                return ResourceManager.GetString("uiMappingRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm Password does not match..
        /// </summary>
        internal static string uiNotMatchPassword {
            get {
                return ResourceManager.GetString("uiNotMatchPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password changed successfully..
        /// </summary>
        internal static string uiPasswordChangeSuccessful {
            get {
                return ResourceManager.GetString("uiPasswordChangeSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a required field..
        /// </summary>
        internal static string uiRequiredValueMessage {
            get {
                return ResourceManager.GetString("uiRequiredValueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your changes have been saved..
        /// </summary>
        internal static string uiSaveCompleted {
            get {
                return ResourceManager.GetString("uiSaveCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save changes made to {0}?.
        /// </summary>
        internal static string uiSaveConfirmation {
            get {
                return ResourceManager.GetString("uiSaveConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan document is released..
        /// </summary>
        internal static string uiScanDocumentReleased {
            get {
                return ResourceManager.GetString("uiScanDocumentReleased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid {0} folder..
        /// </summary>
        internal static string uiSelectInvalidFolder {
            get {
                return ResourceManager.GetString("uiSelectInvalidFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changes saved..
        /// </summary>
        internal static string uiSettingsSaveCompleted {
            get {
                return ResourceManager.GetString("uiSettingsSaveCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully filed..
        /// </summary>
        internal static string uiSuccessfullyFiled {
            get {
                return ResourceManager.GetString("uiSuccessfullyFiled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file format you are attempting to open is not supported in this product version.  Please save the file locally and view it using another image viewer application on your local machine..
        /// </summary>
        internal static string uiTiffFormatInvalid {
            get {
                return ResourceManager.GetString("uiTiffFormatInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Try login again when changing password but not successfully. Username: {0}.
        /// </summary>
        internal static string uiTryLoginFail {
            get {
                return ResourceManager.GetString("uiTryLoginFail", resourceCulture);
            }
        }
    }
}
