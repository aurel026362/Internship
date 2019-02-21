using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    class WeakRef : WeakEventManager
    {

        private WeakRef()
        {

        }

        /// <summary>
        /// Add a handler for the given source's event.
        /// </summary>
        public static void AddHandler(EventSource source,
                                      EventHandler<EventForBank> handler)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (handler == null)
                throw new ArgumentNullException("handler");

            CurrentManager.ProtectedAddHandler(source, handler);
        }

        /// <summary>
        /// Remove a handler for the given source's event.
        /// </summary>
        public static void RemoveHandler(EventSource source,
                                         EventHandler<EventForBank> handler)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (handler == null)
                throw new ArgumentNullException("handler");

            CurrentManager.ProtectedRemoveHandler(source, handler);
        }

        /// <summary>
        /// Get the event manager for the current thread.
        /// </summary>
        private static WeakRef CurrentManager
        {
            get
            {
                Type managerType = typeof(WeakRef);
                WeakRef manager =
                    (WeakRef)GetCurrentManager(managerType);

                // at first use, create and register a new manager
                if (manager == null)
                {
                    manager = new WeakRef();
                    SetCurrentManager(managerType, manager);
                }

                return manager;
            }
        }



        /// <summary>
        /// Return a new list to hold listeners to the event.
        /// </summary>
        protected override ListenerList NewListenerList()
        {
            return new ListenerList<EventForBank>();
        }


        /// <summary>
        /// Listen to the given source for the event.
        /// </summary>
        protected override void StartListening(object source)
        {
            EventSource typedSource = (EventSource)source;
            typedSource.SomeEvent += new EventHandler<EventForBank>(OnSomeEvent);
        }

        /// <summary>
        /// Stop listening to the given source for the event.
        /// </summary>
        protected override void StopListening(object source)
        {
            EventSource typedSource = (EventSource)source;
            typedSource.SomeEvent -= new EventHandler<EventForBank>(OnSomeEvent);
        }

        /// <summary>
        /// Event handler for the SomeEvent event.
        /// </summary>
        void OnSomeEvent(object sender, EventForBank e)
        {
            DeliverEvent(sender, e);
        }
    }
}
