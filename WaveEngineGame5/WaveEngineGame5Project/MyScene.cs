#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Components.Animation;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;
#endregion

namespace WaveEngineGame5Project
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            RenderManager.BackgroundColor = Color.CornflowerBlue;

            var ryu = new Entity("ryu");
            ryu.AddComponent(new Transform2D()
                                 {
                                     X = WaveServices.Platform.ScreenWidth /2,
                                     Y  = WaveServices.Platform.ScreenHeight /2


                                 })
                .AddComponent(Animation2D.Create<RyuXml>("Content/ryu.xml")
                .Add("idle", new SpriteSheetAnimationSequence()
                                                                  {
                                                                             First  = 0,
                                                                             Length = 6,
                                                                             FramesPerSecond = 5
                                                                           }))
                .AddComponent(new Sprite("Content/ryu.wpk"))
                .AddComponent(new AnimatedSpriteRenderer(DefaultLayers.Alpha));

            EntityManager.Add(ryu);
            ryu.FindComponent<Animation2D>().Play(true);
            }
    }
}
