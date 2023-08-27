using Microsoft.AspNetCore.Components;

namespace ExploreBlazorServer.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;


        //public Counter(ILogger<Counter> log)
        //{
        //    Log = log;
        //}

        [Parameter]
        public int StarterValue { get; set; }

        //Inject - value injected by service provider during initialization. Based on configuration using DI
        [Inject]
        public ILogger<Counter> Log { get; set; }

        //--------------------For /counter/{StarterValue:int} URL --------------------
        //We cannot assign the value directly to InitialValue parameter or we cannot use constructor. Need to
        //use below method. Its part of ComponentBase class
        //protected override void OnParametersSet()
        //{
        //    base.OnParametersSet();//Optional
        //    currentCount = StarterValue;//StarterValue is given as URL parameter
        //}

        //Use OnParametersSetAsync for DB call or other call which should be asynchronous
        //TODO: Also explore other methods
        //--------------------------------------------------------------------------------

        //-------------------- To retain counter value based on DI(transient,scoped,singleton) type if CounterService--------------------
        protected override void OnInitialized()
        {
            base.OnInitialized();
            currentCount = CntrService.CounterValue;
        }

        ///<summary>
        /// Method invoked when the component has received parameters from its parent in
        /// the render tree, and the incoming values have been assigned to properties.
        ///</summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        //----------------------------------------------------------------------------------------------------

        private void IncrementCount()
        {
            CntrService.IncrementCounter();
            currentCount = CntrService.CounterValue;
            //throw new Exception("Emulate exception");
            //currentCount++;
        }
    }
}
