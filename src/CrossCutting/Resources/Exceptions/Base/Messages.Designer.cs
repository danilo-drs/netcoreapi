﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template.CrossCutting.Resources.Exceptions.Base {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Messages() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrossCutting.Resources.Exceptions.Base.Messages", typeof(Messages).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0}.
        /// </summary>
        public static string BusinessConflictException {
            get {
                return ResourceManager.GetString("BusinessConflictException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0}.
        /// </summary>
        public static string BusinessRuleException {
            get {
                return ResourceManager.GetString("BusinessRuleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cache &apos;{0}&apos; não encontrado..
        /// </summary>
        public static string CacheNotFoundException {
            get {
                return ResourceManager.GetString("CacheNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Valor &apos;{0}&apos; não encontrado no cache..
        /// </summary>
        public static string CacheValueNotFoundException {
            get {
                return ResourceManager.GetString("CacheValueNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Parâmetros estão inválidos ou incorretos:.
        /// </summary>
        public static string InvalidParameterException {
            get {
                return ResourceManager.GetString("InvalidParameterException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Key &apos;{0}&apos; não encontrado..
        /// </summary>
        public static string KeyNotFoundException {
            get {
                return ResourceManager.GetString("KeyNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Requisição já processada.
        ///{0}.
        /// </summary>
        public static string RequestAlreadyProcessedException {
            get {
                return ResourceManager.GetString("RequestAlreadyProcessedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Acesso negado.
        ///Por favor, contate o administrador do sistema..
        /// </summary>
        public static string ServiceAccessDeniedException {
            get {
                return ResourceManager.GetString("ServiceAccessDeniedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Assinatura não localizada para os dados informados. Provedor: {0} Acordo: {1} SiglaProduto:{2}.
        /// </summary>
        public static string SignatureNotFoundException {
            get {
                return ResourceManager.GetString("SignatureNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Ocorreu um erro inesperado. Por favor, tente novamente mais tarde..
        /// </summary>
        public static string UnpredictableException {
            get {
                return ResourceManager.GetString("UnpredictableException", resourceCulture);
            }
        }
    }
}
