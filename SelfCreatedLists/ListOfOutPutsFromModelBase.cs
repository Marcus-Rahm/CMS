﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.SelfCreatedLists
{
    /// <summary>
    /// Here are all results from the modelbase
    /// -reqForTheJob holds the original req from the GUI
    /// 
    /// -namesWithCert holds all the names that have right cert,
    /// a person is only listed for one cert even if they have the right
    /// cert for multiple of the req certs.
    /// 
    /// -howManyOfEachCertExists holds how many of each cert we have
    /// available. The first cert in reqForTheJob holds the first
    /// index in howManyOfEachCertExists.
    /// 
    /// -howManyMoreOfEachCertNeeded holds how many of each cert we are missing,
    /// the index listing is the same as for howManyOfEachCertExists.
    /// 
    /// -canCompleteInReqDays Says if we can complete the job in the req time without
    /// training more.
    /// 
    /// -timeNeeded says how much time our available employees can work together.
    /// 
    /// -costToTrainMorePeople says the cost of training more people.
    /// </summary>
    class ListOfOutPutsFromModelBase
    {
        public List<JobCertReqList> reqForTheJob;
        public List<String> namesWithCert = new List<String>();
        public List<int> howManyOfEachCertExists = new List<int>();
        public List<int> howManyMoreOfEachCertNeeded = new List<int>();
        public bool canCompleteInReqDays;
        public int timeNeeded;
        public int costToTrainMorePeople;

        public ListOfOutPutsFromModelBase()
        {
            timeNeeded = 0;
            costToTrainMorePeople = 0;
            canCompleteInReqDays = false;
        }
    }
}