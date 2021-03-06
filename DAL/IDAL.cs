﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        #region GuestRequestFonction
        void AddGuestRequest(GuestRequest gs);
        void UpdateGuestRequest(GuestRequest gs);
        GuestRequest GetGuestRequest(long key);
        #endregion

        #region HostFonction
        void AddHost(Host host);
        void UpdateHost(Host host);
        void EraseHost(int key);
        Host GetHost(int key);
        #endregion

        #region HostingUnitFonction
        void AddHostingUnit(HostingUnit hu);
        void EraseHostingUnit(long Key);
        void UpdateHostingUnit(HostingUnit hu);
        HostingUnit GetHostingUnit(long key);
        #endregion

        #region OrderFonction
        void AddOder(Order or);
        void UpdateOrder(Order or);
        Order GetOrder(int key);
        #endregion

        #region List
        IEnumerable<HostingUnit> GetAllHostingUnitCollection(Func<HostingUnit, bool> predicate = null);
        IEnumerable<Host> GetAllHost(Func<Host, bool> predicate = null);
        IEnumerable<Order> GetAllOrder(Func<Order, bool> predicate = null);
        IEnumerable<GuestRequest> GetAllGuestRequest(Func<GuestRequest, bool> predicate = null);
        IEnumerable<BankAccount> GetAllBranch();
        #endregion
    }
}
