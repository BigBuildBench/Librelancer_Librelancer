using System.Numerics;
namespace LibreLancer.Interface;

public partial class WireframeView
{
    private static float SPHERE_OFFSET = -249;
    static readonly Vector3[] sphereWireframe = 
    {
        new(0.000f,100.000f,-0.000f), new(-0.000f,98.079f,-19.509f),
        new(-0.000f,98.079f,-19.509f), new(-7.466f,98.079f,-18.024f),
        new(-7.466f,98.079f,-18.024f), new(0.000f,100.000f,-0.000f),
        new(-7.466f,98.079f,-18.024f), new(-13.795f,98.079f,-13.795f),
        new(-13.795f,98.079f,-13.795f), new(0.000f,100.000f,-0.000f),
        new(-13.795f,98.079f,-13.795f), new(-18.024f,98.079f,-7.466f),
        new(-18.024f,98.079f,-7.466f), new(0.000f,100.000f,-0.000f),
        new(-18.024f,98.079f,-7.466f), new(-19.509f,98.079f,0.000f),
        new(-19.509f,98.079f,0.000f), new(0.000f,100.000f,-0.000f),
        new(-19.509f,98.079f,0.000f), new(-18.024f,98.079f,7.466f),
        new(-18.024f,98.079f,7.466f), new(0.000f,100.000f,-0.000f),
        new(-18.024f,98.079f,7.466f), new(-13.795f,98.079f,13.795f),
        new(-13.795f,98.079f,13.795f), new(0.000f,100.000f,-0.000f),
        new(-13.795f,98.079f,13.795f), new(-7.466f,98.079f,18.024f),
        new(-7.466f,98.079f,18.024f), new(0.000f,100.000f,-0.000f),
        new(-7.466f,98.079f,18.024f), new(0.000f,98.079f,19.509f),
        new(0.000f,98.079f,19.509f), new(0.000f,100.000f,-0.000f),
        new(0.000f,98.079f,19.509f), new(7.466f,98.079f,18.024f),
        new(7.466f,98.079f,18.024f), new(0.000f,100.000f,-0.000f),
        new(7.466f,98.079f,18.024f), new(13.795f,98.079f,13.795f),
        new(13.795f,98.079f,13.795f), new(0.000f,100.000f,-0.000f),
        new(13.795f,98.079f,13.795f), new(18.024f,98.079f,7.466f),
        new(18.024f,98.079f,7.466f), new(0.000f,100.000f,-0.000f),
        new(18.024f,98.079f,7.466f), new(19.509f,98.079f,-0.000f),
        new(19.509f,98.079f,-0.000f), new(0.000f,100.000f,-0.000f),
        new(19.509f,98.079f,-0.000f), new(18.024f,98.079f,-7.466f),
        new(18.024f,98.079f,-7.466f), new(0.000f,100.000f,-0.000f),
        new(18.024f,98.079f,-7.466f), new(13.795f,98.079f,-13.795f),
        new(13.795f,98.079f,-13.795f), new(0.000f,100.000f,-0.000f),
        new(13.795f,98.079f,-13.795f), new(7.466f,98.079f,-18.024f),
        new(7.466f,98.079f,-18.024f), new(0.000f,100.000f,-0.000f),
        new(7.466f,98.079f,-18.024f), new(-0.000f,98.079f,-19.509f),
        new(-0.000f,98.079f,-19.509f), new(-0.000f,92.388f,-38.268f),
        new(-0.000f,92.388f,-38.268f), new(-14.645f,92.388f,-35.355f),
        new(-14.645f,92.388f,-35.355f), new(-7.466f,98.079f,-18.024f),
        new(-14.645f,92.388f,-35.355f), new(-27.060f,92.388f,-27.060f),
        new(-27.060f,92.388f,-27.060f), new(-13.795f,98.079f,-13.795f),
        new(-27.060f,92.388f,-27.060f), new(-35.355f,92.388f,-14.645f),
        new(-35.355f,92.388f,-14.645f), new(-18.024f,98.079f,-7.466f),
        new(-35.355f,92.388f,-14.645f), new(-38.268f,92.388f,0.000f),
        new(-38.268f,92.388f,0.000f), new(-19.509f,98.079f,0.000f),
        new(-38.268f,92.388f,0.000f), new(-35.355f,92.388f,14.645f),
        new(-35.355f,92.388f,14.645f), new(-18.024f,98.079f,7.466f),
        new(-35.355f,92.388f,14.645f), new(-27.060f,92.388f,27.060f),
        new(-27.060f,92.388f,27.060f), new(-13.795f,98.079f,13.795f),
        new(-27.060f,92.388f,27.060f), new(-14.645f,92.388f,35.355f),
        new(-14.645f,92.388f,35.355f), new(-7.466f,98.079f,18.024f),
        new(-14.645f,92.388f,35.355f), new(0.000f,92.388f,38.268f),
        new(0.000f,92.388f,38.268f), new(0.000f,98.079f,19.509f),
        new(0.000f,92.388f,38.268f), new(14.645f,92.388f,35.355f),
        new(14.645f,92.388f,35.355f), new(7.466f,98.079f,18.024f),
        new(14.645f,92.388f,35.355f), new(27.060f,92.388f,27.060f),
        new(27.060f,92.388f,27.060f), new(13.795f,98.079f,13.795f),
        new(27.060f,92.388f,27.060f), new(35.355f,92.388f,14.645f),
        new(35.355f,92.388f,14.645f), new(18.024f,98.079f,7.466f),
        new(35.355f,92.388f,14.645f), new(38.268f,92.388f,-0.000f),
        new(38.268f,92.388f,-0.000f), new(19.509f,98.079f,-0.000f),
        new(38.268f,92.388f,-0.000f), new(35.355f,92.388f,-14.645f),
        new(35.355f,92.388f,-14.645f), new(18.024f,98.079f,-7.466f),
        new(35.355f,92.388f,-14.645f), new(27.060f,92.388f,-27.060f),
        new(27.060f,92.388f,-27.060f), new(13.795f,98.079f,-13.795f),
        new(27.060f,92.388f,-27.060f), new(14.645f,92.388f,-35.355f),
        new(14.645f,92.388f,-35.355f), new(7.466f,98.079f,-18.024f),
        new(14.645f,92.388f,-35.355f), new(-0.000f,92.388f,-38.268f),
        new(-0.000f,92.388f,-38.268f), new(-0.000f,83.147f,-55.557f),
        new(-0.000f,83.147f,-55.557f), new(-21.261f,83.147f,-51.328f),
        new(-21.261f,83.147f,-51.328f), new(-14.645f,92.388f,-35.355f),
        new(-21.261f,83.147f,-51.328f), new(-39.285f,83.147f,-39.285f),
        new(-39.285f,83.147f,-39.285f), new(-27.060f,92.388f,-27.060f),
        new(-39.285f,83.147f,-39.285f), new(-51.328f,83.147f,-21.261f),
        new(-51.328f,83.147f,-21.261f), new(-35.355f,92.388f,-14.645f),
        new(-51.328f,83.147f,-21.261f), new(-55.557f,83.147f,0.000f),
        new(-55.557f,83.147f,0.000f), new(-38.268f,92.388f,0.000f),
        new(-55.557f,83.147f,0.000f), new(-51.328f,83.147f,21.261f),
        new(-51.328f,83.147f,21.261f), new(-35.355f,92.388f,14.645f),
        new(-51.328f,83.147f,21.261f), new(-39.285f,83.147f,39.285f),
        new(-39.285f,83.147f,39.285f), new(-27.060f,92.388f,27.060f),
        new(-39.285f,83.147f,39.285f), new(-21.261f,83.147f,51.328f),
        new(-21.261f,83.147f,51.328f), new(-14.645f,92.388f,35.355f),
        new(-21.261f,83.147f,51.328f), new(0.000f,83.147f,55.557f),
        new(0.000f,83.147f,55.557f), new(0.000f,92.388f,38.268f),
        new(0.000f,83.147f,55.557f), new(21.261f,83.147f,51.328f),
        new(21.261f,83.147f,51.328f), new(14.645f,92.388f,35.355f),
        new(21.261f,83.147f,51.328f), new(39.285f,83.147f,39.285f),
        new(39.285f,83.147f,39.285f), new(27.060f,92.388f,27.060f),
        new(39.285f,83.147f,39.285f), new(51.328f,83.147f,21.261f),
        new(51.328f,83.147f,21.261f), new(35.355f,92.388f,14.645f),
        new(51.328f,83.147f,21.261f), new(55.557f,83.147f,-0.000f),
        new(55.557f,83.147f,-0.000f), new(38.268f,92.388f,-0.000f),
        new(55.557f,83.147f,-0.000f), new(51.328f,83.147f,-21.261f),
        new(51.328f,83.147f,-21.261f), new(35.355f,92.388f,-14.645f),
        new(51.328f,83.147f,-21.261f), new(39.285f,83.147f,-39.285f),
        new(39.285f,83.147f,-39.285f), new(27.060f,92.388f,-27.060f),
        new(39.285f,83.147f,-39.285f), new(21.261f,83.147f,-51.328f),
        new(21.261f,83.147f,-51.328f), new(14.645f,92.388f,-35.355f),
        new(21.261f,83.147f,-51.328f), new(-0.000f,83.147f,-55.557f),
        new(-0.000f,83.147f,-55.557f), new(-0.000f,70.711f,-70.711f),
        new(-0.000f,70.711f,-70.711f), new(-27.060f,70.711f,-65.328f),
        new(-27.060f,70.711f,-65.328f), new(-21.261f,83.147f,-51.328f),
        new(-27.060f,70.711f,-65.328f), new(-50.000f,70.711f,-50.000f),
        new(-50.000f,70.711f,-50.000f), new(-39.285f,83.147f,-39.285f),
        new(-50.000f,70.711f,-50.000f), new(-65.328f,70.711f,-27.060f),
        new(-65.328f,70.711f,-27.060f), new(-51.328f,83.147f,-21.261f),
        new(-65.328f,70.711f,-27.060f), new(-70.711f,70.711f,0.000f),
        new(-70.711f,70.711f,0.000f), new(-55.557f,83.147f,0.000f),
        new(-70.711f,70.711f,0.000f), new(-65.328f,70.711f,27.060f),
        new(-65.328f,70.711f,27.060f), new(-51.328f,83.147f,21.261f),
        new(-65.328f,70.711f,27.060f), new(-50.000f,70.711f,50.000f),
        new(-50.000f,70.711f,50.000f), new(-39.285f,83.147f,39.285f),
        new(-50.000f,70.711f,50.000f), new(-27.060f,70.711f,65.328f),
        new(-27.060f,70.711f,65.328f), new(-21.261f,83.147f,51.328f),
        new(-27.060f,70.711f,65.328f), new(0.000f,70.711f,70.711f),
        new(0.000f,70.711f,70.711f), new(0.000f,83.147f,55.557f),
        new(0.000f,70.711f,70.711f), new(27.060f,70.711f,65.328f),
        new(27.060f,70.711f,65.328f), new(21.261f,83.147f,51.328f),
        new(27.060f,70.711f,65.328f), new(50.000f,70.711f,50.000f),
        new(50.000f,70.711f,50.000f), new(39.285f,83.147f,39.285f),
        new(50.000f,70.711f,50.000f), new(65.328f,70.711f,27.060f),
        new(65.328f,70.711f,27.060f), new(51.328f,83.147f,21.261f),
        new(65.328f,70.711f,27.060f), new(70.711f,70.711f,-0.000f),
        new(70.711f,70.711f,-0.000f), new(55.557f,83.147f,-0.000f),
        new(70.711f,70.711f,-0.000f), new(65.328f,70.711f,-27.060f),
        new(65.328f,70.711f,-27.060f), new(51.328f,83.147f,-21.261f),
        new(65.328f,70.711f,-27.060f), new(50.000f,70.711f,-50.000f),
        new(50.000f,70.711f,-50.000f), new(39.285f,83.147f,-39.285f),
        new(50.000f,70.711f,-50.000f), new(27.060f,70.711f,-65.328f),
        new(27.060f,70.711f,-65.328f), new(21.261f,83.147f,-51.328f),
        new(27.060f,70.711f,-65.328f), new(-0.000f,70.711f,-70.711f),
        new(-0.000f,70.711f,-70.711f), new(-0.000f,55.557f,-83.147f),
        new(-0.000f,55.557f,-83.147f), new(-31.819f,55.557f,-76.818f),
        new(-31.819f,55.557f,-76.818f), new(-27.060f,70.711f,-65.328f),
        new(-31.819f,55.557f,-76.818f), new(-58.794f,55.557f,-58.794f),
        new(-58.794f,55.557f,-58.794f), new(-50.000f,70.711f,-50.000f),
        new(-58.794f,55.557f,-58.794f), new(-76.818f,55.557f,-31.819f),
        new(-76.818f,55.557f,-31.819f), new(-65.328f,70.711f,-27.060f),
        new(-76.818f,55.557f,-31.819f), new(-83.147f,55.557f,0.000f),
        new(-83.147f,55.557f,0.000f), new(-70.711f,70.711f,0.000f),
        new(-83.147f,55.557f,0.000f), new(-76.818f,55.557f,31.819f),
        new(-76.818f,55.557f,31.819f), new(-65.328f,70.711f,27.060f),
        new(-76.818f,55.557f,31.819f), new(-58.794f,55.557f,58.794f),
        new(-58.794f,55.557f,58.794f), new(-50.000f,70.711f,50.000f),
        new(-58.794f,55.557f,58.794f), new(-31.819f,55.557f,76.818f),
        new(-31.819f,55.557f,76.818f), new(-27.060f,70.711f,65.328f),
        new(-31.819f,55.557f,76.818f), new(0.000f,55.557f,83.147f),
        new(0.000f,55.557f,83.147f), new(0.000f,70.711f,70.711f),
        new(0.000f,55.557f,83.147f), new(31.819f,55.557f,76.818f),
        new(31.819f,55.557f,76.818f), new(27.060f,70.711f,65.328f),
        new(31.819f,55.557f,76.818f), new(58.794f,55.557f,58.794f),
        new(58.794f,55.557f,58.794f), new(50.000f,70.711f,50.000f),
        new(58.794f,55.557f,58.794f), new(76.818f,55.557f,31.819f),
        new(76.818f,55.557f,31.819f), new(65.328f,70.711f,27.060f),
        new(76.818f,55.557f,31.819f), new(83.147f,55.557f,-0.000f),
        new(83.147f,55.557f,-0.000f), new(70.711f,70.711f,-0.000f),
        new(83.147f,55.557f,-0.000f), new(76.818f,55.557f,-31.819f),
        new(76.818f,55.557f,-31.819f), new(65.328f,70.711f,-27.060f),
        new(76.818f,55.557f,-31.819f), new(58.794f,55.557f,-58.794f),
        new(58.794f,55.557f,-58.794f), new(50.000f,70.711f,-50.000f),
        new(58.794f,55.557f,-58.794f), new(31.819f,55.557f,-76.818f),
        new(31.819f,55.557f,-76.818f), new(27.060f,70.711f,-65.328f),
        new(31.819f,55.557f,-76.818f), new(-0.000f,55.557f,-83.147f),
        new(-0.000f,55.557f,-83.147f), new(-0.000f,38.268f,-92.388f),
        new(-0.000f,38.268f,-92.388f), new(-35.355f,38.268f,-85.355f),
        new(-35.355f,38.268f,-85.355f), new(-31.819f,55.557f,-76.818f),
        new(-35.355f,38.268f,-85.355f), new(-65.328f,38.268f,-65.328f),
        new(-65.328f,38.268f,-65.328f), new(-58.794f,55.557f,-58.794f),
        new(-65.328f,38.268f,-65.328f), new(-85.355f,38.268f,-35.355f),
        new(-85.355f,38.268f,-35.355f), new(-76.818f,55.557f,-31.819f),
        new(-85.355f,38.268f,-35.355f), new(-92.388f,38.268f,0.000f),
        new(-92.388f,38.268f,0.000f), new(-83.147f,55.557f,0.000f),
        new(-92.388f,38.268f,0.000f), new(-85.355f,38.268f,35.355f),
        new(-85.355f,38.268f,35.355f), new(-76.818f,55.557f,31.819f),
        new(-85.355f,38.268f,35.355f), new(-65.328f,38.268f,65.328f),
        new(-65.328f,38.268f,65.328f), new(-58.794f,55.557f,58.794f),
        new(-65.328f,38.268f,65.328f), new(-35.355f,38.268f,85.355f),
        new(-35.355f,38.268f,85.355f), new(-31.819f,55.557f,76.818f),
        new(-35.355f,38.268f,85.355f), new(0.000f,38.268f,92.388f),
        new(0.000f,38.268f,92.388f), new(0.000f,55.557f,83.147f),
        new(0.000f,38.268f,92.388f), new(35.355f,38.268f,85.355f),
        new(35.355f,38.268f,85.355f), new(31.819f,55.557f,76.818f),
        new(35.355f,38.268f,85.355f), new(65.328f,38.268f,65.328f),
        new(65.328f,38.268f,65.328f), new(58.794f,55.557f,58.794f),
        new(65.328f,38.268f,65.328f), new(85.355f,38.268f,35.355f),
        new(85.355f,38.268f,35.355f), new(76.818f,55.557f,31.819f),
        new(85.355f,38.268f,35.355f), new(92.388f,38.268f,-0.000f),
        new(92.388f,38.268f,-0.000f), new(83.147f,55.557f,-0.000f),
        new(92.388f,38.268f,-0.000f), new(85.355f,38.268f,-35.355f),
        new(85.355f,38.268f,-35.355f), new(76.818f,55.557f,-31.819f),
        new(85.355f,38.268f,-35.355f), new(65.328f,38.268f,-65.328f),
        new(65.328f,38.268f,-65.328f), new(58.794f,55.557f,-58.794f),
        new(65.328f,38.268f,-65.328f), new(35.355f,38.268f,-85.355f),
        new(35.355f,38.268f,-85.355f), new(31.819f,55.557f,-76.818f),
        new(35.355f,38.268f,-85.355f), new(-0.000f,38.268f,-92.388f),
        new(-0.000f,38.268f,-92.388f), new(-0.000f,19.509f,-98.079f),
        new(-0.000f,19.509f,-98.079f), new(-37.533f,19.509f,-90.613f),
        new(-37.533f,19.509f,-90.613f), new(-35.355f,38.268f,-85.355f),
        new(-37.533f,19.509f,-90.613f), new(-69.352f,19.509f,-69.352f),
        new(-69.352f,19.509f,-69.352f), new(-65.328f,38.268f,-65.328f),
        new(-69.352f,19.509f,-69.352f), new(-90.613f,19.509f,-37.533f),
        new(-90.613f,19.509f,-37.533f), new(-85.355f,38.268f,-35.355f),
        new(-90.613f,19.509f,-37.533f), new(-98.079f,19.509f,0.000f),
        new(-98.079f,19.509f,0.000f), new(-92.388f,38.268f,0.000f),
        new(-98.079f,19.509f,0.000f), new(-90.613f,19.509f,37.533f),
        new(-90.613f,19.509f,37.533f), new(-85.355f,38.268f,35.355f),
        new(-90.613f,19.509f,37.533f), new(-69.352f,19.509f,69.352f),
        new(-69.352f,19.509f,69.352f), new(-65.328f,38.268f,65.328f),
        new(-69.352f,19.509f,69.352f), new(-37.533f,19.509f,90.613f),
        new(-37.533f,19.509f,90.613f), new(-35.355f,38.268f,85.355f),
        new(-37.533f,19.509f,90.613f), new(0.000f,19.509f,98.079f),
        new(0.000f,19.509f,98.079f), new(0.000f,38.268f,92.388f),
        new(0.000f,19.509f,98.079f), new(37.533f,19.509f,90.613f),
        new(37.533f,19.509f,90.613f), new(35.355f,38.268f,85.355f),
        new(37.533f,19.509f,90.613f), new(69.352f,19.509f,69.352f),
        new(69.352f,19.509f,69.352f), new(65.328f,38.268f,65.328f),
        new(69.352f,19.509f,69.352f), new(90.613f,19.509f,37.533f),
        new(90.613f,19.509f,37.533f), new(85.355f,38.268f,35.355f),
        new(90.613f,19.509f,37.533f), new(98.079f,19.509f,-0.000f),
        new(98.079f,19.509f,-0.000f), new(92.388f,38.268f,-0.000f),
        new(98.079f,19.509f,-0.000f), new(90.613f,19.509f,-37.533f),
        new(90.613f,19.509f,-37.533f), new(85.355f,38.268f,-35.355f),
        new(90.613f,19.509f,-37.533f), new(69.352f,19.509f,-69.352f),
        new(69.352f,19.509f,-69.352f), new(65.328f,38.268f,-65.328f),
        new(69.352f,19.509f,-69.352f), new(37.533f,19.509f,-90.613f),
        new(37.533f,19.509f,-90.613f), new(35.355f,38.268f,-85.355f),
        new(37.533f,19.509f,-90.613f), new(-0.000f,19.509f,-98.079f),
        new(-0.000f,19.509f,-98.079f), new(-0.000f,0.000f,-100.000f),
        new(-0.000f,0.000f,-100.000f), new(-38.268f,0.000f,-92.388f),
        new(-38.268f,0.000f,-92.388f), new(-37.533f,19.509f,-90.613f),
        new(-38.268f,0.000f,-92.388f), new(-70.711f,0.000f,-70.711f),
        new(-70.711f,0.000f,-70.711f), new(-69.352f,19.509f,-69.352f),
        new(-70.711f,0.000f,-70.711f), new(-92.388f,0.000f,-38.268f),
        new(-92.388f,0.000f,-38.268f), new(-90.613f,19.509f,-37.533f),
        new(-92.388f,0.000f,-38.268f), new(-100.000f,0.000f,0.000f),
        new(-100.000f,0.000f,0.000f), new(-98.079f,19.509f,0.000f),
        new(-100.000f,0.000f,0.000f), new(-92.388f,0.000f,38.268f),
        new(-92.388f,0.000f,38.268f), new(-90.613f,19.509f,37.533f),
        new(-92.388f,0.000f,38.268f), new(-70.711f,0.000f,70.711f),
        new(-70.711f,0.000f,70.711f), new(-69.352f,19.509f,69.352f),
        new(-70.711f,0.000f,70.711f), new(-38.268f,0.000f,92.388f),
        new(-38.268f,0.000f,92.388f), new(-37.533f,19.509f,90.613f),
        new(-38.268f,0.000f,92.388f), new(0.000f,0.000f,100.000f),
        new(0.000f,0.000f,100.000f), new(0.000f,19.509f,98.079f),
        new(0.000f,0.000f,100.000f), new(38.268f,0.000f,92.388f),
        new(38.268f,0.000f,92.388f), new(37.533f,19.509f,90.613f),
        new(38.268f,0.000f,92.388f), new(70.711f,0.000f,70.711f),
        new(70.711f,0.000f,70.711f), new(69.352f,19.509f,69.352f),
        new(70.711f,0.000f,70.711f), new(92.388f,0.000f,38.268f),
        new(92.388f,0.000f,38.268f), new(90.613f,19.509f,37.533f),
        new(92.388f,0.000f,38.268f), new(100.000f,0.000f,-0.000f),
        new(100.000f,0.000f,-0.000f), new(98.079f,19.509f,-0.000f),
        new(100.000f,0.000f,-0.000f), new(92.388f,0.000f,-38.269f),
        new(92.388f,0.000f,-38.269f), new(90.613f,19.509f,-37.533f),
        new(92.388f,0.000f,-38.269f), new(70.711f,0.000f,-70.711f),
        new(70.711f,0.000f,-70.711f), new(69.352f,19.509f,-69.352f),
        new(70.711f,0.000f,-70.711f), new(38.268f,0.000f,-92.388f),
        new(38.268f,0.000f,-92.388f), new(37.533f,19.509f,-90.613f),
        new(38.268f,0.000f,-92.388f), new(-0.000f,0.000f,-100.000f),
        new(-0.000f,0.000f,-100.000f), new(-0.000f,-19.509f,-98.079f),
        new(-0.000f,-19.509f,-98.079f), new(-37.533f,-19.509f,-90.613f),
        new(-37.533f,-19.509f,-90.613f), new(-38.268f,0.000f,-92.388f),
        new(-37.533f,-19.509f,-90.613f), new(-69.352f,-19.509f,-69.352f),
        new(-69.352f,-19.509f,-69.352f), new(-70.711f,0.000f,-70.711f),
        new(-69.352f,-19.509f,-69.352f), new(-90.613f,-19.509f,-37.533f),
        new(-90.613f,-19.509f,-37.533f), new(-92.388f,0.000f,-38.268f),
        new(-90.613f,-19.509f,-37.533f), new(-98.079f,-19.509f,0.000f),
        new(-98.079f,-19.509f,0.000f), new(-100.000f,0.000f,0.000f),
        new(-98.079f,-19.509f,0.000f), new(-90.613f,-19.509f,37.533f),
        new(-90.613f,-19.509f,37.533f), new(-92.388f,0.000f,38.268f),
        new(-90.613f,-19.509f,37.533f), new(-69.352f,-19.509f,69.352f),
        new(-69.352f,-19.509f,69.352f), new(-70.711f,0.000f,70.711f),
        new(-69.352f,-19.509f,69.352f), new(-37.533f,-19.509f,90.613f),
        new(-37.533f,-19.509f,90.613f), new(-38.268f,0.000f,92.388f),
        new(-37.533f,-19.509f,90.613f), new(0.000f,-19.509f,98.079f),
        new(0.000f,-19.509f,98.079f), new(0.000f,0.000f,100.000f),
        new(0.000f,-19.509f,98.079f), new(37.533f,-19.509f,90.613f),
        new(37.533f,-19.509f,90.613f), new(38.268f,0.000f,92.388f),
        new(37.533f,-19.509f,90.613f), new(69.352f,-19.509f,69.352f),
        new(69.352f,-19.509f,69.352f), new(70.711f,0.000f,70.711f),
        new(69.352f,-19.509f,69.352f), new(90.613f,-19.509f,37.533f),
        new(90.613f,-19.509f,37.533f), new(92.388f,0.000f,38.268f),
        new(90.613f,-19.509f,37.533f), new(98.079f,-19.509f,-0.000f),
        new(98.079f,-19.509f,-0.000f), new(100.000f,0.000f,-0.000f),
        new(98.079f,-19.509f,-0.000f), new(90.613f,-19.509f,-37.533f),
        new(90.613f,-19.509f,-37.533f), new(92.388f,0.000f,-38.269f),
        new(90.613f,-19.509f,-37.533f), new(69.352f,-19.509f,-69.352f),
        new(69.352f,-19.509f,-69.352f), new(70.711f,0.000f,-70.711f),
        new(69.352f,-19.509f,-69.352f), new(37.533f,-19.509f,-90.613f),
        new(37.533f,-19.509f,-90.613f), new(38.268f,0.000f,-92.388f),
        new(37.533f,-19.509f,-90.613f), new(-0.000f,-19.509f,-98.079f),
        new(-0.000f,-19.509f,-98.079f), new(-0.000f,-38.268f,-92.388f),
        new(-0.000f,-38.268f,-92.388f), new(-35.355f,-38.268f,-85.355f),
        new(-35.355f,-38.268f,-85.355f), new(-37.533f,-19.509f,-90.613f),
        new(-35.355f,-38.268f,-85.355f), new(-65.328f,-38.268f,-65.328f),
        new(-65.328f,-38.268f,-65.328f), new(-69.352f,-19.509f,-69.352f),
        new(-65.328f,-38.268f,-65.328f), new(-85.355f,-38.268f,-35.355f),
        new(-85.355f,-38.268f,-35.355f), new(-90.613f,-19.509f,-37.533f),
        new(-85.355f,-38.268f,-35.355f), new(-92.388f,-38.268f,0.000f),
        new(-92.388f,-38.268f,0.000f), new(-98.079f,-19.509f,0.000f),
        new(-92.388f,-38.268f,0.000f), new(-85.355f,-38.268f,35.355f),
        new(-85.355f,-38.268f,35.355f), new(-90.613f,-19.509f,37.533f),
        new(-85.355f,-38.268f,35.355f), new(-65.328f,-38.268f,65.328f),
        new(-65.328f,-38.268f,65.328f), new(-69.352f,-19.509f,69.352f),
        new(-65.328f,-38.268f,65.328f), new(-35.355f,-38.268f,85.355f),
        new(-35.355f,-38.268f,85.355f), new(-37.533f,-19.509f,90.613f),
        new(-35.355f,-38.268f,85.355f), new(0.000f,-38.268f,92.388f),
        new(0.000f,-38.268f,92.388f), new(0.000f,-19.509f,98.079f),
        new(0.000f,-38.268f,92.388f), new(35.355f,-38.268f,85.355f),
        new(35.355f,-38.268f,85.355f), new(37.533f,-19.509f,90.613f),
        new(35.355f,-38.268f,85.355f), new(65.328f,-38.268f,65.328f),
        new(65.328f,-38.268f,65.328f), new(69.352f,-19.509f,69.352f),
        new(65.328f,-38.268f,65.328f), new(85.355f,-38.268f,35.355f),
        new(85.355f,-38.268f,35.355f), new(90.613f,-19.509f,37.533f),
        new(85.355f,-38.268f,35.355f), new(92.388f,-38.268f,-0.000f),
        new(92.388f,-38.268f,-0.000f), new(98.079f,-19.509f,-0.000f),
        new(92.388f,-38.268f,-0.000f), new(85.355f,-38.268f,-35.355f),
        new(85.355f,-38.268f,-35.355f), new(90.613f,-19.509f,-37.533f),
        new(85.355f,-38.268f,-35.355f), new(65.328f,-38.268f,-65.328f),
        new(65.328f,-38.268f,-65.328f), new(69.352f,-19.509f,-69.352f),
        new(65.328f,-38.268f,-65.328f), new(35.355f,-38.268f,-85.355f),
        new(35.355f,-38.268f,-85.355f), new(37.533f,-19.509f,-90.613f),
        new(35.355f,-38.268f,-85.355f), new(-0.000f,-38.268f,-92.388f),
        new(-0.000f,-38.268f,-92.388f), new(-0.000f,-55.557f,-83.147f),
        new(-0.000f,-55.557f,-83.147f), new(-31.819f,-55.557f,-76.818f),
        new(-31.819f,-55.557f,-76.818f), new(-35.355f,-38.268f,-85.355f),
        new(-31.819f,-55.557f,-76.818f), new(-58.794f,-55.557f,-58.794f),
        new(-58.794f,-55.557f,-58.794f), new(-65.328f,-38.268f,-65.328f),
        new(-58.794f,-55.557f,-58.794f), new(-76.818f,-55.557f,-31.819f),
        new(-76.818f,-55.557f,-31.819f), new(-85.355f,-38.268f,-35.355f),
        new(-76.818f,-55.557f,-31.819f), new(-83.147f,-55.557f,0.000f),
        new(-83.147f,-55.557f,0.000f), new(-92.388f,-38.268f,0.000f),
        new(-83.147f,-55.557f,0.000f), new(-76.818f,-55.557f,31.819f),
        new(-76.818f,-55.557f,31.819f), new(-85.355f,-38.268f,35.355f),
        new(-76.818f,-55.557f,31.819f), new(-58.794f,-55.557f,58.794f),
        new(-58.794f,-55.557f,58.794f), new(-65.328f,-38.268f,65.328f),
        new(-58.794f,-55.557f,58.794f), new(-31.819f,-55.557f,76.818f),
        new(-31.819f,-55.557f,76.818f), new(-35.355f,-38.268f,85.355f),
        new(-31.819f,-55.557f,76.818f), new(0.000f,-55.557f,83.147f),
        new(0.000f,-55.557f,83.147f), new(0.000f,-38.268f,92.388f),
        new(0.000f,-55.557f,83.147f), new(31.819f,-55.557f,76.818f),
        new(31.819f,-55.557f,76.818f), new(35.355f,-38.268f,85.355f),
        new(31.819f,-55.557f,76.818f), new(58.794f,-55.557f,58.794f),
        new(58.794f,-55.557f,58.794f), new(65.328f,-38.268f,65.328f),
        new(58.794f,-55.557f,58.794f), new(76.818f,-55.557f,31.819f),
        new(76.818f,-55.557f,31.819f), new(85.355f,-38.268f,35.355f),
        new(76.818f,-55.557f,31.819f), new(83.147f,-55.557f,-0.000f),
        new(83.147f,-55.557f,-0.000f), new(92.388f,-38.268f,-0.000f),
        new(83.147f,-55.557f,-0.000f), new(76.818f,-55.557f,-31.819f),
        new(76.818f,-55.557f,-31.819f), new(85.355f,-38.268f,-35.355f),
        new(76.818f,-55.557f,-31.819f), new(58.794f,-55.557f,-58.794f),
        new(58.794f,-55.557f,-58.794f), new(65.328f,-38.268f,-65.328f),
        new(58.794f,-55.557f,-58.794f), new(31.819f,-55.557f,-76.818f),
        new(31.819f,-55.557f,-76.818f), new(35.355f,-38.268f,-85.355f),
        new(31.819f,-55.557f,-76.818f), new(-0.000f,-55.557f,-83.147f),
        new(-0.000f,-55.557f,-83.147f), new(-0.000f,-70.711f,-70.711f),
        new(-0.000f,-70.711f,-70.711f), new(-27.060f,-70.711f,-65.328f),
        new(-27.060f,-70.711f,-65.328f), new(-31.819f,-55.557f,-76.818f),
        new(-27.060f,-70.711f,-65.328f), new(-50.000f,-70.711f,-50.000f),
        new(-50.000f,-70.711f,-50.000f), new(-58.794f,-55.557f,-58.794f),
        new(-50.000f,-70.711f,-50.000f), new(-65.328f,-70.711f,-27.060f),
        new(-65.328f,-70.711f,-27.060f), new(-76.818f,-55.557f,-31.819f),
        new(-65.328f,-70.711f,-27.060f), new(-70.711f,-70.711f,0.000f),
        new(-70.711f,-70.711f,0.000f), new(-83.147f,-55.557f,0.000f),
        new(-70.711f,-70.711f,0.000f), new(-65.328f,-70.711f,27.060f),
        new(-65.328f,-70.711f,27.060f), new(-76.818f,-55.557f,31.819f),
        new(-65.328f,-70.711f,27.060f), new(-50.000f,-70.711f,50.000f),
        new(-50.000f,-70.711f,50.000f), new(-58.794f,-55.557f,58.794f),
        new(-50.000f,-70.711f,50.000f), new(-27.060f,-70.711f,65.328f),
        new(-27.060f,-70.711f,65.328f), new(-31.819f,-55.557f,76.818f),
        new(-27.060f,-70.711f,65.328f), new(0.000f,-70.711f,70.711f),
        new(0.000f,-70.711f,70.711f), new(0.000f,-55.557f,83.147f),
        new(0.000f,-70.711f,70.711f), new(27.060f,-70.711f,65.328f),
        new(27.060f,-70.711f,65.328f), new(31.819f,-55.557f,76.818f),
        new(27.060f,-70.711f,65.328f), new(50.000f,-70.711f,50.000f),
        new(50.000f,-70.711f,50.000f), new(58.794f,-55.557f,58.794f),
        new(50.000f,-70.711f,50.000f), new(65.328f,-70.711f,27.060f),
        new(65.328f,-70.711f,27.060f), new(76.818f,-55.557f,31.819f),
        new(65.328f,-70.711f,27.060f), new(70.711f,-70.711f,-0.000f),
        new(70.711f,-70.711f,-0.000f), new(83.147f,-55.557f,-0.000f),
        new(70.711f,-70.711f,-0.000f), new(65.328f,-70.711f,-27.060f),
        new(65.328f,-70.711f,-27.060f), new(76.818f,-55.557f,-31.819f),
        new(65.328f,-70.711f,-27.060f), new(50.000f,-70.711f,-50.000f),
        new(50.000f,-70.711f,-50.000f), new(58.794f,-55.557f,-58.794f),
        new(50.000f,-70.711f,-50.000f), new(27.060f,-70.711f,-65.328f),
        new(27.060f,-70.711f,-65.328f), new(31.819f,-55.557f,-76.818f),
        new(27.060f,-70.711f,-65.328f), new(-0.000f,-70.711f,-70.711f),
        new(-0.000f,-70.711f,-70.711f), new(-0.000f,-83.147f,-55.557f),
        new(-0.000f,-83.147f,-55.557f), new(-21.261f,-83.147f,-51.328f),
        new(-21.261f,-83.147f,-51.328f), new(-27.060f,-70.711f,-65.328f),
        new(-21.261f,-83.147f,-51.328f), new(-39.285f,-83.147f,-39.285f),
        new(-39.285f,-83.147f,-39.285f), new(-50.000f,-70.711f,-50.000f),
        new(-39.285f,-83.147f,-39.285f), new(-51.328f,-83.147f,-21.261f),
        new(-51.328f,-83.147f,-21.261f), new(-65.328f,-70.711f,-27.060f),
        new(-51.328f,-83.147f,-21.261f), new(-55.557f,-83.147f,0.000f),
        new(-55.557f,-83.147f,0.000f), new(-70.711f,-70.711f,0.000f),
        new(-55.557f,-83.147f,0.000f), new(-51.328f,-83.147f,21.261f),
        new(-51.328f,-83.147f,21.261f), new(-65.328f,-70.711f,27.060f),
        new(-51.328f,-83.147f,21.261f), new(-39.285f,-83.147f,39.285f),
        new(-39.285f,-83.147f,39.285f), new(-50.000f,-70.711f,50.000f),
        new(-39.285f,-83.147f,39.285f), new(-21.261f,-83.147f,51.328f),
        new(-21.261f,-83.147f,51.328f), new(-27.060f,-70.711f,65.328f),
        new(-21.261f,-83.147f,51.328f), new(0.000f,-83.147f,55.557f),
        new(0.000f,-83.147f,55.557f), new(0.000f,-70.711f,70.711f),
        new(0.000f,-83.147f,55.557f), new(21.261f,-83.147f,51.328f),
        new(21.261f,-83.147f,51.328f), new(27.060f,-70.711f,65.328f),
        new(21.261f,-83.147f,51.328f), new(39.285f,-83.147f,39.285f),
        new(39.285f,-83.147f,39.285f), new(50.000f,-70.711f,50.000f),
        new(39.285f,-83.147f,39.285f), new(51.328f,-83.147f,21.261f),
        new(51.328f,-83.147f,21.261f), new(65.328f,-70.711f,27.060f),
        new(51.328f,-83.147f,21.261f), new(55.557f,-83.147f,-0.000f),
        new(55.557f,-83.147f,-0.000f), new(70.711f,-70.711f,-0.000f),
        new(55.557f,-83.147f,-0.000f), new(51.328f,-83.147f,-21.261f),
        new(51.328f,-83.147f,-21.261f), new(65.328f,-70.711f,-27.060f),
        new(51.328f,-83.147f,-21.261f), new(39.285f,-83.147f,-39.285f),
        new(39.285f,-83.147f,-39.285f), new(50.000f,-70.711f,-50.000f),
        new(39.285f,-83.147f,-39.285f), new(21.261f,-83.147f,-51.328f),
        new(21.261f,-83.147f,-51.328f), new(27.060f,-70.711f,-65.328f),
        new(21.261f,-83.147f,-51.328f), new(-0.000f,-83.147f,-55.557f),
        new(-0.000f,-83.147f,-55.557f), new(-0.000f,-92.388f,-38.268f),
        new(-0.000f,-92.388f,-38.268f), new(-14.645f,-92.388f,-35.355f),
        new(-14.645f,-92.388f,-35.355f), new(-21.261f,-83.147f,-51.328f),
        new(-14.645f,-92.388f,-35.355f), new(-27.060f,-92.388f,-27.060f),
        new(-27.060f,-92.388f,-27.060f), new(-39.285f,-83.147f,-39.285f),
        new(-27.060f,-92.388f,-27.060f), new(-35.355f,-92.388f,-14.645f),
        new(-35.355f,-92.388f,-14.645f), new(-51.328f,-83.147f,-21.261f),
        new(-35.355f,-92.388f,-14.645f), new(-38.268f,-92.388f,0.000f),
        new(-38.268f,-92.388f,0.000f), new(-55.557f,-83.147f,0.000f),
        new(-38.268f,-92.388f,0.000f), new(-35.355f,-92.388f,14.645f),
        new(-35.355f,-92.388f,14.645f), new(-51.328f,-83.147f,21.261f),
        new(-35.355f,-92.388f,14.645f), new(-27.060f,-92.388f,27.060f),
        new(-27.060f,-92.388f,27.060f), new(-39.285f,-83.147f,39.285f),
        new(-27.060f,-92.388f,27.060f), new(-14.645f,-92.388f,35.355f),
        new(-14.645f,-92.388f,35.355f), new(-21.261f,-83.147f,51.328f),
        new(-14.645f,-92.388f,35.355f), new(0.000f,-92.388f,38.268f),
        new(0.000f,-92.388f,38.268f), new(0.000f,-83.147f,55.557f),
        new(0.000f,-92.388f,38.268f), new(14.645f,-92.388f,35.355f),
        new(14.645f,-92.388f,35.355f), new(21.261f,-83.147f,51.328f),
        new(14.645f,-92.388f,35.355f), new(27.060f,-92.388f,27.060f),
        new(27.060f,-92.388f,27.060f), new(39.285f,-83.147f,39.285f),
        new(27.060f,-92.388f,27.060f), new(35.355f,-92.388f,14.645f),
        new(35.355f,-92.388f,14.645f), new(51.328f,-83.147f,21.261f),
        new(35.355f,-92.388f,14.645f), new(38.268f,-92.388f,-0.000f),
        new(38.268f,-92.388f,-0.000f), new(55.557f,-83.147f,-0.000f),
        new(38.268f,-92.388f,-0.000f), new(35.355f,-92.388f,-14.645f),
        new(35.355f,-92.388f,-14.645f), new(51.328f,-83.147f,-21.261f),
        new(35.355f,-92.388f,-14.645f), new(27.060f,-92.388f,-27.060f),
        new(27.060f,-92.388f,-27.060f), new(39.285f,-83.147f,-39.285f),
        new(27.060f,-92.388f,-27.060f), new(14.645f,-92.388f,-35.355f),
        new(14.645f,-92.388f,-35.355f), new(21.261f,-83.147f,-51.328f),
        new(14.645f,-92.388f,-35.355f), new(-0.000f,-92.388f,-38.268f),
        new(-0.000f,-92.388f,-38.268f), new(-0.000f,-98.079f,-19.509f),
        new(-0.000f,-98.079f,-19.509f), new(-7.466f,-98.079f,-18.024f),
        new(-7.466f,-98.079f,-18.024f), new(-14.645f,-92.388f,-35.355f),
        new(-7.466f,-98.079f,-18.024f), new(-13.795f,-98.079f,-13.795f),
        new(-13.795f,-98.079f,-13.795f), new(-27.060f,-92.388f,-27.060f),
        new(-13.795f,-98.079f,-13.795f), new(-18.024f,-98.079f,-7.466f),
        new(-18.024f,-98.079f,-7.466f), new(-35.355f,-92.388f,-14.645f),
        new(-18.024f,-98.079f,-7.466f), new(-19.509f,-98.079f,0.000f),
        new(-19.509f,-98.079f,0.000f), new(-38.268f,-92.388f,0.000f),
        new(-19.509f,-98.079f,0.000f), new(-18.024f,-98.079f,7.466f),
        new(-18.024f,-98.079f,7.466f), new(-35.355f,-92.388f,14.645f),
        new(-18.024f,-98.079f,7.466f), new(-13.795f,-98.079f,13.795f),
        new(-13.795f,-98.079f,13.795f), new(-27.060f,-92.388f,27.060f),
        new(-13.795f,-98.079f,13.795f), new(-7.466f,-98.079f,18.024f),
        new(-7.466f,-98.079f,18.024f), new(-14.645f,-92.388f,35.355f),
        new(-7.466f,-98.079f,18.024f), new(0.000f,-98.079f,19.509f),
        new(0.000f,-98.079f,19.509f), new(0.000f,-92.388f,38.268f),
        new(0.000f,-98.079f,19.509f), new(7.466f,-98.079f,18.024f),
        new(7.466f,-98.079f,18.024f), new(14.645f,-92.388f,35.355f),
        new(7.466f,-98.079f,18.024f), new(13.795f,-98.079f,13.795f),
        new(13.795f,-98.079f,13.795f), new(27.060f,-92.388f,27.060f),
        new(13.795f,-98.079f,13.795f), new(18.024f,-98.079f,7.466f),
        new(18.024f,-98.079f,7.466f), new(35.355f,-92.388f,14.645f),
        new(18.024f,-98.079f,7.466f), new(19.509f,-98.079f,-0.000f),
        new(19.509f,-98.079f,-0.000f), new(38.268f,-92.388f,-0.000f),
        new(19.509f,-98.079f,-0.000f), new(18.024f,-98.079f,-7.466f),
        new(18.024f,-98.079f,-7.466f), new(35.355f,-92.388f,-14.645f),
        new(18.024f,-98.079f,-7.466f), new(13.795f,-98.079f,-13.795f),
        new(13.795f,-98.079f,-13.795f), new(27.060f,-92.388f,-27.060f),
        new(13.795f,-98.079f,-13.795f), new(7.466f,-98.079f,-18.024f),
        new(7.466f,-98.079f,-18.024f), new(14.645f,-92.388f,-35.355f),
        new(7.466f,-98.079f,-18.024f), new(-0.000f,-98.079f,-19.509f),
        new(0.000f,-100.000f,-0.000f), new(-7.466f,-98.079f,-18.024f),
        new(-0.000f,-98.079f,-19.509f), new(0.000f,-100.000f,-0.000f),
        new(0.000f,-100.000f,-0.000f), new(-13.795f,-98.079f,-13.795f),
        new(0.000f,-100.000f,-0.000f), new(-18.024f,-98.079f,-7.466f),
        new(0.000f,-100.000f,-0.000f), new(-19.509f,-98.079f,0.000f),
        new(0.000f,-100.000f,-0.000f), new(-18.024f,-98.079f,7.466f),
        new(0.000f,-100.000f,-0.000f), new(-13.795f,-98.079f,13.795f),
        new(0.000f,-100.000f,-0.000f), new(-7.466f,-98.079f,18.024f),
        new(0.000f,-100.000f,-0.000f), new(0.000f,-98.079f,19.509f),
        new(0.000f,-100.000f,-0.000f), new(7.466f,-98.079f,18.024f),
        new(0.000f,-100.000f,-0.000f), new(13.795f,-98.079f,13.795f),
        new(0.000f,-100.000f,-0.000f), new(18.024f,-98.079f,7.466f),
        new(0.000f,-100.000f,-0.000f), new(19.509f,-98.079f,-0.000f),
        new(0.000f,-100.000f,-0.000f), new(18.024f,-98.079f,-7.466f),
        new(0.000f,-100.000f,-0.000f), new(13.795f,-98.079f,-13.795f),
        new(0.000f,-100.000f,-0.000f), new(7.466f,-98.079f,-18.024f),
    };
}