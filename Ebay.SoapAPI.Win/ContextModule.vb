Imports Ebay.Service.Core.Soap
Imports Ebay.Service.Core.Sdk
Imports System.Configuration

Module ContextModule
    Private apiContext As ApiContext = Nothing

    ''' <summary>
    ''' Populate eBay SDK ApiContext instance with data from application configuration file
    ''' </summary>
    ''' <returns>ApiContext instance</returns>
    ''' <remarks></remarks>
    Public Function GetApiContext() As ApiContext

        'apiContext is a singleton
        'to avoid duplicate configuration reading
        If (apiContext IsNot Nothing) Then
            Return apiContext
        End If

        apiContext = New ApiContext()

        'set Api Server Url
        apiContext.SoapApiServerUrl =
                 ConfigurationManager.AppSettings.Get("Environment.ApiServerUrl")

        'set Api Token to access eBay Api Server
        Dim apiCredential As ApiCredential = New ApiCredential()
        apiCredential.eBayToken = ConfigurationManager.AppSettings.Get("UserAccount.ApiToken")
        apiContext.ApiCredential = apiCredential

        'set eBay Site target to US
        apiContext.Site = SiteCodeType.US


        Return apiContext



    End Function
End Module
