﻿' SignalR
Imports Microsoft.AspNet.SignalR
Imports Microsoft.AspNet.SignalR.Hubs

<HubName("VBDemo")>
Public Class VBDemoHub
    Inherits Hub

    Public Overrides Function OnConnectedAsync() As Task
        Clients.CallerState.message = "Why?"

        ' Invoke a method on the client so the updated state is also sent
        Clients.Caller.anyMethodNameWillDo()

        Return MyBase.OnConnectedAsync()
    End Function

    Public Function ReadStateValue()
        Return Clients.CallerState.message
    End Function
End Class
