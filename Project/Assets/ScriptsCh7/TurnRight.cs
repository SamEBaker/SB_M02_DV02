using Chapter.EventBus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class TurnRight : Command
    {
        private BController _controller;
        public TurnRight(BController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(BController.Direction.Right);
        }
    }
}
