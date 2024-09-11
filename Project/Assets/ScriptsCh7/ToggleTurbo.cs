using Chapter.EventBus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private BController _controller;
        public ToggleTurbo(BController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}
