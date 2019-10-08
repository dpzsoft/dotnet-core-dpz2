using System;

namespace demo {
    class Program {
        static void Main(string[] args) {

            string xml = "<database version=\"1.01.1711.002\">\r\n" +
                "  <platform name=\"Activity\" title=\"活动信息\">\r\n" +
                "    <table name=\"ActivityNew\" version=\"1.0.1810.2\" path=\"/Activity/ActivityNew.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"AI\" title=\"人工智能\">\r\n" +
                "    <table name=\"AIWords\" version=\"2016.0401\" path=\"/AI/AIWords.xml\"></table>\r\n" +
                "    <table name=\"AIMemory\" version=\"2016.0401\" path=\"/AI/AIMemory.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"Aos\" title=\"框架数据库\">\r\n" +
                "    <table name=\"AosObjects\" version=\"2016.1102\" path=\"/Aos/AosObjects.xml\"></table>\r\n" +
                "    <table name=\"AosAuthorize\" version=\"1.5.1904.16\" path=\"/Aos/AosAuthorize.xml\"></table>\r\n" +
                "    <table name=\"AosAuthorizeCode\" version=\"1711.0002\" path=\"/Aos/AosAuthorizeCode.xml\"></table>\r\n" +
                "    <table name=\"AosSessions\" version=\"2016.0601\" path=\"/Aos/AosSessions.xml\"></table>\r\n" +
                "    <table name=\"AosSessionProcesses\" version=\"2016.0601\" path=\"/Aos/AosSessionProcesses.xml\"></table>\r\n" +
                "    <table name=\"AosSessionValues\" version=\"2016.1002\" path=\"/Aos/AosSessionValues.xml\"></table>\r\n" +
                "    <table name=\"AosLog\" version=\"1512.0501\" path=\"/Aos/AosLog.xml\"></table>\r\n" +
                "    <table name=\"AosLogInterfaceData\" version=\"1711.0002\" path=\"/Aos/AosLogInterfaceData.xml\"></table>\r\n" +
                "    <table name=\"AosApps\" version=\"1.2.1905.9\" path=\"/Aos/AosApps.xml\"></table>\r\n" +
                "    <table name=\"AosAppStores\" version=\"1.0.1904.1\" path=\"/Aos/AosAppStores.xml\"></table>\r\n" +
                "    <table name=\"AosPlugs\" version=\"1512.0501\" path=\"/Aos/AosPlugs.xml\"></table>\r\n" +
                "    <table name=\"AosUsers\" version=\"1711.0005\" path=\"/Aos/AosUsers.xml\"></table>\r\n" +
                "    <table name=\"AosLimits\" version=\"1612.0002\" path=\"/Aos/AosLimits.xml\"></table>\r\n" +
                "    <table name=\"AosIPInfo\" version=\"2016.0501\" path=\"/Aos/AosIPInfo.xml\"></table>\r\n" +
                "    <table name=\"AosUserApps\" version=\"1708.0002\" path=\"/Aos/AosUserApps.xml\"></table>\r\n" +
                "    <table name=\"AosUserAuthorize\" version=\"1.0.1904.3\" path=\"/Aos/AosUserAuthorize.xml\"></table>\r\n" +
                "    <table name=\"AosUserSetting\" version=\"2016.1101\" path=\"/Aos/AosUserSetting.xml\"></table>\r\n" +
                "    <table name=\"AosSetting\" version=\"2016.1201\" path=\"/Aos/AosSetting.xml\"></table>\r\n" +
                "    <table name=\"AosAppLimits\" version=\"1612.0001\" path=\"/Aos/AosAppLimits.xml\"></table>\r\n" +
                "    <table name=\"AosAppCatalogs\" version=\"1612.0001\" path=\"/Aos/AosAppCatalogs.xml\"></table>\r\n" +
                "    <table name=\"AosCount\" version=\"1612.0001\" path=\"/Aos/AosCount.xml\"></table>\r\n" +
                "    <table name=\"AosDesktopApps\" version=\"1.1.1810.2\" path=\"/Aos/AosDesktopApps.xml\"></table>\r\n" +
                "    <table name=\"AosDesktopAuthorizes\" version=\"1.0.1904.1\" path=\"/Aos/AosDesktopAuthorizes.xml\"></table>\r\n" +
                "    <table name=\"AosDesktops\" version=\"1.2.1902.4\" path=\"/Aos/AosDesktops.xml\"></table>\r\n" +
                "    <table name=\"AosThirdWeixin\" version=\"1705.0001\" path=\"/Aos/AosThirdWeixin.xml\"></table>\r\n" +
                "    <table name=\"AosFiles\" version=\"1709.0001\" path=\"/Aos/AosFiles.xml\"></table>\r\n" +
                "    <table name=\"AosMessages\" version=\"1709.0001\" path=\"/Aos/AosMessages.xml\"></table>\r\n" +
                "    <table name=\"AosMessagesRead\" version=\"1709.0001\" path=\"/Aos/AosMessagesRead.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"App\" title=\"应用\">\r\n" +
                "    <table name=\"AppInfos\" version=\"1708.0002\" path=\"/App/AppInfos.xml\"></table>\r\n" +
                "    <table name=\"AppLimits\" version=\"1706.0001\" path=\"/App/AppLimits.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"Assess\" title=\"考核\">\r\n" +
                "    <table name=\"AssessInfos\" version=\"1711.0001\" path=\"/Assess/AssessInfos.xml\"></table>\r\n" +
                "    <table name=\"AssessItems\" version=\"1711.0003\" path=\"/Assess/AssessItems.xml\"></table>\r\n" +
                "    <table name=\"AssessScore\" version=\"1712.0003\" path=\"/Assess/AssessScore.xml\"></table>\r\n" +
                "    <table name=\"AssessItemScore\" version=\"1711.0004\" path=\"/Assess/AssessItemScore.xml\"></table>\r\n" +
                "    <table name=\"AssessRoundScore\" version=\"1711.0001\" path=\"/Assess/AssessRoundScore.xml\"></table>\r\n" +
                "    <table name=\"AssessUsers\" version=\"1711.0001\" path=\"/Assess/AssessUsers.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"Base\" title=\"基础功能\">\r\n" +
                "    <table name=\"SystemObjects\" version=\"1706.0002\" path=\"/Base/SystemObjects.xml\"></table>\r\n" +
                "    <table name=\"SystemLimits\" version=\"1706.0001\" path=\"/Base/SystemLimits.xml\"></table>\r\n" +
                "    <table name=\"SystemObjectLimits\" version=\"1706.0001\" path=\"/Base/SystemObjectLimits.xml\"></table>\r\n" +
                "    <table name=\"SystemUsers\" version=\"1706.0003\" path=\"/Base/SystemUsers.xml\"></table>\r\n" +
                "    <table name=\"SystemUserAppLimits\" version=\"1512.2001\" path=\"/Base/SystemUserAppLimits.xml\"></table>\r\n" +
                "    <table name=\"SystemUserLimits\" version=\"1512.0501\" path=\"/Base/SystemUserLimits.xml\"></table>\r\n" +
                "    <table name=\"SystemMessages\" version=\"1512.0501\" path=\"/Base/SystemMessages.xml\"></table>\r\n" +
                "    <table name=\"SystemCatalog\" version=\"1706.0002\" path=\"/Base/SystemCatalog.xml\"></table>\r\n" +
                "    <table name=\"SystemTableTypes\" version=\"1511.0901\" path=\"/Base/SystemTableTypes.xml\"></table>\r\n" +
                "    <table name=\"SystemTables\" version=\"1706.0002\" path=\"/Base/SystemTables.xml\"></table>\r\n" +
                "    <table name=\"SystemColumns\" version=\"1706.0003\" path=\"/Base/SystemColumns.xml\"></table>\r\n" +
                "    <table name=\"SystemUserTableVisits\" version=\"1512.1101\" path=\"/Base/SystemUserTableVisits.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"Chat\" title=\"聊天\">\r\n" +
                "    <table name=\"ChatInfo\" version=\"1703.0002\" path=\"/Chat/ChatInfo.xml\"></table>\r\n" +
                "    <table name=\"ChatToUser\" version=\"1703.0003\" path=\"/Chat/ChatToUser.xml\"></table>\r\n" +
                "    <table name=\"ChatToGroup\" version=\"1703.0001\" path=\"/Chat/ChatToGroup.xml\"></table>\r\n" +
                "    <table name=\"ChatMessage\" version=\"1703.0002\" path=\"/Chat/ChatMessage.xml\"></table>\r\n" +
                "    <table name=\"ChatReceive\" version=\"1703.0002\" path=\"/Chat/ChatReceive.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"Cloud\" title=\"企业云\">\r\n" +
                "    <table name=\"CloudList\" version=\"2016.0902\" path=\"/Cloud/CloudList.xml\"></table>\r\n" +
                "    <table name=\"CloudHistory\" version=\"2016.0401\" path=\"/Cloud/CloudHistory.xml\"></table>\r\n" +
                "    <table name=\"CloudFiles\" version=\"2016.1106\" path=\"/Cloud/CloudFiles.xml\"></table>\r\n" +
                "    <table name=\"CloudFileHistory\" version=\"2016.0401\" path=\"/Cloud/CloudFileHistory.xml\"></table>\r\n" +
                "    <table name=\"CloudUserStore\" version=\"2016.0801\" path=\"/Cloud/CloudUserStore.xml\"></table>\r\n" +
                "    <table name=\"CloudOfficeFiles\" version=\"2016.1101\" path=\"/Cloud/CloudOfficeFiles.xml\"></table>\r\n" +
                "    <table name=\"CloudExchangeFiles\" version=\"1703.0002\" path=\"/Cloud/CloudExchangeFiles.xml\"></table>\r\n" +
                "  </platform>\r\n" +
                "  <platform name=\"CloudStorage\" title=\"云存储\">" +
                "    <table name=\"CloudStorageDisk\" version=\"1.0.1810.2\" path=\"/CloudStorage/CloudStorageDisk.xml\"></table>" +
                "    <table name=\"CloudStorageFolder\" version=\"1806.0002\" path=\"/CloudStorage/CloudStorageFolder.xml\"></table>" +
                "    <table name=\"CloudStorageFile\" version=\"1806.0004\" path=\"/CloudStorage/CloudStorageFile.xml\"></table>" +
                "    <table name=\"CloudStorageFileUpload\" version=\"1805.0002\" path=\"/CloudStorage/CloudStorageFileUpload.xml\"></table>" +
                "    <table name=\"CloudStorageFileShare\" version=\"1804.0001\" path=\"/CloudStorage/CloudStorageFileShare.xml\"></table>" +
                "  </platform>" +
                "  <platform name=\"CPA\" title=\"会计事务所专用\">" +
                "    <table name=\"CPAClient\" version=\"1712.0002\" path=\"/CPA/CPAClient.xml\"></table>" +
                "    <table name=\"CPAAccountClient\" version=\"1803.0008\" path=\"/CPA/CPAAccountClient.xml\"></table>" +
                "    <table name=\"CPAAccountProcess\" version=\"1701.0003\" path=\"/CPA/CPAAccountProcess.xml\"></table>" +
                "    <table name=\"CPAAccountProcessAssessCriteria\" version=\"1712.0001\" path=\"/CPA/CPAAccountProcessAssessCriteria.xml\"></table>" +
                "    <table name=\"CPAAccountProcessAssessScore\" version=\"1712.0001\" path=\"/CPA/CPAAccountProcessAssessScore.xml\"></table>" +
                "    <table name=\"CPAFinalSettlementClient\" version=\"1712.0002\" path=\"/CPA/CPAFinalSettlementClient.xml\"></table>" +
                "    <table name=\"CPAFinalSettlementProcess\" version=\"2016.0402\" path=\"/CPA/CPAFinalSettlementProcess.xml\"></table>" +
                "    <table name=\"CPAFinalSettlementYear\" version=\"2016.0401\" path=\"/CPA/CPAFinalSettlementYear.xml\"></table>" +
                "    <table name=\"CPACheck01\" version=\"1712.0004\" path=\"/CPA/CPACheck01.xml\"></table>" +
                "    <table name=\"CPACheck02\" version=\"1712.0004\" path=\"/CPA/CPACheck02.xml\"></table>" +
                "    <table name=\"CPACheck03\" version=\"1712.0004\" path=\"/CPA/CPACheck03.xml\"></table>" +
                "    <table name=\"CPAAccredClient\" version=\"1712.0002\" path=\"/CPA/CPAAccredClient.xml\"></table>" +
                "    <table name=\"CPAAccredProcess\" version=\"2016.1201\" path=\"/CPA/CPAAccredProcess.xml\"></table>" +
                "    <table name=\"CPAAccountCount\" version=\"1712.0002\" path=\"/CPA/CPAAccountCount.xml\"></table>" +
                "  </platform>" +
                "</database>";

            string xml2 = "<?xml version=\"1.0\" ?><xml><node1>123</node1><node2>234</node2></xml>";

            var nodes = dpz2.Xml.Parser.GetNodes(xml2);
            if (nodes.Count > 0) {
                Console.WriteLine(nodes[0].OuterXml);
            }

            string xml3 = dpz2.File.UTF8File.ReadAllText(@"X:\Projects\yytol\dotnet-core-ycp-entity-manager\Xml\UI\Aos\AosAuthorize.xml");
            using (var doc = dpz2.Xml.Parser.GetDocument(xml3)) {
                Console.WriteLine(doc.InnerXml);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
