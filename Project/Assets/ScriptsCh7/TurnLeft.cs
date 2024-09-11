using Chapter.EventBus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private BController _controller;
        public TurnLeft(BController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(BController.Direction.Left);
        }
    }
}
