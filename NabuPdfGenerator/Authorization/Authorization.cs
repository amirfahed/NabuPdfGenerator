﻿using NLog;
using Novell.Directory.Ldap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NabuPdfGenerator.Authorization
{
    public class Authorization
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        string LdapHost { get; set; } = "localhost";
        int LdapPort { get; set; } = 10389;
        //string SearchBase = "ou=users,o=Company";
        //string SearchFilter = "some";

        public string Authorize(string LoginON, string Password)
        {
            try
            {
                LdapHost = ConfigurationManager.AppSettings.Get("LdapHost");
                LdapPort = int.Parse(ConfigurationManager.AppSettings.Get("LdapPort"));
                LdapConnection connection = new LdapConnection();
                connection.Connect(LdapHost, LdapPort);
                connection.Bind(LoginON, Password);

                #region Поиск аттрибутов на всякий
                // какая то штука хз зачем
                //string[] requiredAttributes = { "cn", "sn", "uid" };
                //var ldapSearchResult = (LdapSearchResults) connection.Search(SearchBase,
                //    LdapConnection.ScopeSub, SearchFilter, requiredAttributes, false);
                
                //while (ldapSearchResult.HasMore())
                //{
                //    LdapEntry nextEntry = null;
                //    try
                //    {
                //        nextEntry = ldapSearchResult.Next();
                //    }
                //    catch(Exception e)
                //    {
                //        throw e;
                //    }
                //    LdapAttributeSet attributeset = nextEntry.GetAttributeSet();
                //    System.Collections.IEnumerator enumerator = attributeset.GetEnumerator();
                //    while(enumerator.MoveNext())
                //    {
                //        LdapAttribute ldapAttribute = (LdapAttribute) enumerator.Current;
                //        string ldapAttributeName = ldapAttribute.Name;
                //        string ldapAttributeValue = ldapAttribute.StringValue;
                //    }
                //}
                #endregion
                return "";
            }
            catch (Exception e)
            {
                logger.Error(e, $"ошибка авторизации, e.Message = {e.Message}, e.StackTrace= {e.StackTrace}");
                throw e;
            }

        }
    }
}