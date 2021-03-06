﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using ISocketLite.PCL.EventArgs;
using ISocketLite.PCL.Interface;
using SocketLite.Services.Base;
using static SocketLite.Helper.Helper;

namespace SocketLite.Services
{
    public class UdpSocketReceiver : UdpSocketBase, IUdpSocketReceiver
    {
        public int Port { get; }
        public bool IsUnicastActive { get; } = false;

        public bool IsMulticastActive { get; } = false;

        public IObservable<IUdpMessage> ObservableMessages { get; } = null;

        public IObservable<IUdpMessage> CreateObservableListener(int port = 0, ICommunicationInterface communicationInterface = null,
            bool allowMultipleBindToSamePort = false)
        {
            throw new NotImplementedException();
        }

        public Task StartListeningAsync(
            int port, 
            ICommunicationInterface communicationInterface,
            bool allowMultipleBindToSamePort = false)
        {
            throw new NotImplementedException(BaitNoSwitch);
        }

        public void MulticastDropMembership(string ipLan, string mcastAddress)
        {
            throw new NotImplementedException();
        }

        public void StopListening()
        {
            throw new NotImplementedException(BaitNoSwitch);
        }

        public void Dispose()
        {
            throw new NotImplementedException(BaitNoSwitch);
        }

        Task<IObservable<IUdpMessage>> IUdpSocketReceiver.ObservableUnicastListener(int port, ICommunicationInterface communicationInterface, bool allowMultipleBindToSamePort)
        {
            throw new NotImplementedException();
        }

        public void MulticastAddMembership(string ipLan, string mcastAddress)
        {
            throw new NotImplementedException();
        }
    }
}
