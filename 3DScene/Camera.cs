using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene
{
    public static class Camera
    {

        public static Matrix4x4 GetMatrix(Scene scene)
        {
            switch (Properties.cameraType)
            {
                case Properties.CameraType.CenterMode:
                    return Matrix4x4.CreateLookAt(new Vector3(0, 350, 600), new Vector3(0, 0, 0), new Vector3(0, 1, 0));
                case Properties.CameraType.StationaryMode:
                    {
                        var target = scene.fish.polygons[0].vertices[0].worldPosition;
                        return Matrix4x4.CreateLookAt(new Vector3(400, -100, 0), new Vector3(target.X, target.Y, target.Z), new Vector3(0, 1, 0));
                    }
                case Properties.CameraType.MovingMode:
                    {
                        var target = scene.fish.polygons[0].vertices[0].modelPosition;
                        var position = new Vector4(target.X + 3, target.Y - 2, target.Z - 3, target.W);
                        position = Vector4.Transform(position, scene.fish.modelMatrix);
                        target = Vector4.Transform(target, scene.fish.modelMatrix);
                        return Matrix4x4.CreateLookAt(new Vector3(position.X / position.W, position.Y / position.W, position.Z / position.W),
                            new Vector3(target.X / target.W, target.Y / target.W, target.Z / target.W), new Vector3(0, 1, 0));
                    }
            }
            return Matrix4x4.Identity;
        }

        public static Vector3 GetCameraPosition(Scene scene)
        {
            switch (Properties.cameraType)
            {
                case Properties.CameraType.CenterMode:
                    return new Vector3(0, 350, 600);
                case Properties.CameraType.StationaryMode:
                    {
                        var target = scene.fish.polygons[0].vertices[0].worldPosition;
                        return new Vector3(400, -100, 0);
                    }
                case Properties.CameraType.MovingMode:
                    {
                        var target = scene.fish.polygons[0].vertices[0].modelPosition;
                        var position = new Vector4(target.X + 3, target.Y - 2, target.Z - 3, target.W);
                        position = Vector4.Transform(position, scene.fish.modelMatrix);
                        target = Vector4.Transform(target, scene.fish.modelMatrix);
                        return new Vector3(position.X / position.W, position.Y / position.W, position.Z / position.W);
                    }
            }

            return Vector3.Zero;
        }

        public static Vector3 GetSpotLightPosition(Scene scene)
        {
            var target = scene.fish.polygons[0].vertices[0].modelPosition;
            var position = new Vector4(target.X - 10, target.Y - 2, target.Z - 3, target.W);
            position = Vector4.Transform(position, scene.fish.modelMatrix);
            target = Vector4.Transform(target, scene.fish.modelMatrix);
            return new Vector3(position.X / position.W, position.Y / position.W, position.Z / position.W);
        }
        public static Vector3 GetSpotLightTarget(Scene scene)
        {
            var target = scene.fish.polygons[0].vertices[0].modelPosition;
            var position = new Vector4(target.X, target.Y - 2, target.Z - 3, target.W);
            position = Vector4.Transform(position, scene.fish.modelMatrix);
            target = Vector4.Transform(target, scene.fish.modelMatrix);
            return new Vector3(position.X / position.W, position.Y / position.W, position.Z / position.W);
        }
    }
}
