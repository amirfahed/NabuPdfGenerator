using Novell.Directory.Ldap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NabuPdfGenerator.Authorization
{
    public class Authorization
    {
        string LdapHost = "localhost";
        int LdapPort = 10389;
        //string LoginON = "uid=admin,ou=system";
        //string Password = "secret";
        string SearchBase = "ou=users,o=Company";
        string SearchFilter = "some";

        public string Authorize(string LoginON, string Password)
        {
            try
            {
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
                throw e;
            }

        }
    }
}