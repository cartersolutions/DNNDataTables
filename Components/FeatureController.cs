/*
' Copyright (c) 2020 Tony Carter
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;

namespace DNNDataTables.Modules.Components
{
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.Services.Tokens;
    using DotNetNuke.UI.Modules;
    using System.Collections.Generic;
    using System.Web.UI;

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for DNNDataTables
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController: ICustomTokenProvider //: IPortable, ISearchable, IUpgradeable
    {

        public IDictionary<string, IPropertyAccess> GetTokens(Page page, ModuleInstanceContext moduleContext)
        {
            var tokens = new Dictionary<string, IPropertyAccess>();
            tokens["moduleproperties"] = new ModulePropertiesPropertyAccess(moduleContext);
            return tokens;
        }

        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<DNNDataTablesInfo> colDNNDataTabless = GetDNNDataTabless(ModuleID);
        //if (colDNNDataTabless.Count != 0)
        //{
        //    strXML += "<DNNDataTabless>";

        //    foreach (DNNDataTablesInfo objDNNDataTables in colDNNDataTabless)
        //    {
        //        strXML += "<DNNDataTables>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDNNDataTables.Content) + "</content>";
        //        strXML += "</DNNDataTables>";
        //    }
        //    strXML += "</DNNDataTabless>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDNNDataTabless = DotNetNuke.Common.Globals.GetContent(Content, "DNNDataTabless");
        //foreach (XmlNode xmlDNNDataTables in xmlDNNDataTabless.SelectNodes("DNNDataTables"))
        //{
        //    DNNDataTablesInfo objDNNDataTables = new DNNDataTablesInfo();
        //    objDNNDataTables.ModuleId = ModuleID;
        //    objDNNDataTables.Content = xmlDNNDataTables.SelectSingleNode("content").InnerText;
        //    objDNNDataTables.CreatedByUser = UserID;
        //    AddDNNDataTables(objDNNDataTables);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<DNNDataTablesInfo> colDNNDataTabless = GetDNNDataTabless(ModInfo.ModuleID);

        //foreach (DNNDataTablesInfo objDNNDataTables in colDNNDataTabless)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDNNDataTables.Content, objDNNDataTables.CreatedByUser, objDNNDataTables.CreatedDate, ModInfo.ModuleID, objDNNDataTables.ItemId.ToString(), objDNNDataTables.Content, "ItemId=" + objDNNDataTables.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
