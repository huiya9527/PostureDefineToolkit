using System;

namespace PostureDefinationToolkit
{
    public class PuppetBodyData
    {
        const double HEAD_HEIGHT = 0.113;
        const double HEAD_BREADTH = 0.0678;
        const double NECK_BREADTH = 0.0339;
        const double NECK_LENGTH = 0.072;
        const double SHOULDER_BREADTH = 0.224;
        const double SHOULDER_HEIGHT = 0.244;
        //const double UPPER_ARM_LENGTH = 0.205;
        const double UPPER_ARM_LENGTH = 0.140;
        //const double FOREARM_LENGTH = 0.141;
        const double FOREARM_LENGTH = 0.128;
        const double HAND_LENGTH = 0.109;
        const double BUTTOCKS_HEIGHT = 0.011;
        const double PELVIS = 0.15;//0.182;
        const double THIGH_LENGTH = 0.205;
        const double SHANK_LENGTH = 0.261;
        const double ANKLE_HEIGHT = 0.045;

        public string HipCenterX { get; set; }
        public string HipCenterY { get; set; }

        public string SpineX { get; set; }
        public string SpineY { get; set; }

        public string HeadX { get; set; }
        public string HeadY { get; set; }

        public string ShoulderCenterX { get; set; }
        public string ShoulderCenterY { get; set; }

        public string ShoulderLeftX { get; set; }
        public string ShoulderLeftY { get; set; }

        public string ShoulderRightX { get; set; }
        public string ShoulderRightY { get; set; }

        public string ElbowLeftX { get; set; }
        public string ElbowLeftY { get; set; }

        public string ElbowRightX { get; set; }
        public string ElbowRightY { get; set; }

        public string WristLeftX { get; set; }
        public string WristLeftY { get; set; }

        public string WristRightX { get; set; }
        public string WristRightY { get; set; }

        public string HandLeftX { get; set; }
        public string HandLeftY { get; set; }

        public string HandRightX { get; set; }
        public string HandRightY { get; set; }

        public string HipLeftX { get; set; }
        public string HipLeftY { get; set; }

        public string HipRightX { get; set; }
        public string HipRightY { get; set; }

        public string KneeLeftX { get; set; }
        public string KneeLeftY { get; set; }

        public string KneeRightX { get; set; }
        public string KneeRightY { get; set; }

        public string AngleLeftX { get; set; }
        public string AngleLeftY { get; set; }

        public string AngleRightX { get; set; }
        public string AngleRightY { get; set; }

        public string FootLeftX { get; set; }
        public string FootLeftY { get; set; }

        public string FootRightX { get; set; }
        public string FootRightY { get; set; }


        public PuppetBodyData(Double _Stature)
        {
      
            HipCenterX = "255";
            HipCenterY = "310";

            SpineX = Convert.ToString(int.Parse(HipCenterX));
            SpineY = Convert.ToString(int.Parse(HipCenterY) - SHOULDER_HEIGHT * _Stature / 2);

            HeadX = Convert.ToString(int.Parse(HipCenterX));
            HeadY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT + NECK_LENGTH + HEAD_HEIGHT / 2.0) * _Stature);

            ShoulderCenterX = Convert.ToString(int.Parse(HipCenterX));
            ShoulderCenterY = Convert.ToString(int.Parse(HipCenterY) - SHOULDER_HEIGHT * _Stature);

            ShoulderLeftX = Convert.ToString(int.Parse(HipCenterX) - SHOULDER_BREADTH / 2 * _Stature);
            ShoulderLeftY = Convert.ToString(int.Parse(HipCenterY) - SHOULDER_HEIGHT * _Stature);

            ShoulderRightX = Convert.ToString(int.Parse(HipCenterX) + SHOULDER_BREADTH / 2 * _Stature);
            ShoulderRightY = Convert.ToString(int.Parse(HipCenterY) - SHOULDER_HEIGHT * _Stature);

            ElbowLeftX = Convert.ToString(int.Parse(HipCenterX) - SHOULDER_BREADTH / 2 * _Stature);
            ElbowLeftY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH) * _Stature);

            ElbowRightX = Convert.ToString(int.Parse(HipCenterX) + SHOULDER_BREADTH / 2 * _Stature);
            ElbowRightY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH) * _Stature);

            WristLeftX = Convert.ToString(int.Parse(HipCenterX) - SHOULDER_BREADTH / 2 * _Stature);
            WristLeftY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH - FOREARM_LENGTH) * _Stature);

            WristRightX = Convert.ToString(int.Parse(HipCenterX) + SHOULDER_BREADTH / 2 * _Stature);
            WristRightY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH - FOREARM_LENGTH) * _Stature);

            HandLeftX = Convert.ToString(int.Parse(HipCenterX) - SHOULDER_BREADTH / 2 * _Stature);
            HandLeftY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH - FOREARM_LENGTH - HAND_LENGTH) * _Stature);

            HandRightX = Convert.ToString(int.Parse(HipCenterX) + SHOULDER_BREADTH / 2 * _Stature);
            HandRightY = Convert.ToString(int.Parse(HipCenterY) - (SHOULDER_HEIGHT - UPPER_ARM_LENGTH - FOREARM_LENGTH - HAND_LENGTH) * _Stature);

            HipLeftX = Convert.ToString(int.Parse(HipCenterX) - PELVIS * _Stature / 2);
            HipLeftY = Convert.ToString(int.Parse(HipCenterY) + BUTTOCKS_HEIGHT * _Stature);

            HipRightX = Convert.ToString(int.Parse(HipCenterX) + PELVIS * _Stature / 2);
            HipRightY = Convert.ToString(int.Parse(HipCenterY) + BUTTOCKS_HEIGHT * _Stature);

            KneeLeftX = Convert.ToString(int.Parse(HipCenterX) - PELVIS * _Stature / 2);
            KneeLeftY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH) * _Stature);

            KneeRightX = Convert.ToString(int.Parse(HipCenterX) + PELVIS * _Stature / 2);
            KneeRightY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH) * _Stature);

            AngleLeftX = Convert.ToString(int.Parse(HipCenterX) - PELVIS * _Stature / 2);
            AngleLeftY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH + SHANK_LENGTH) * _Stature);

            AngleRightX = Convert.ToString(int.Parse(HipCenterX) + PELVIS * _Stature / 2);
            AngleRightY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH + SHANK_LENGTH) * _Stature);

            FootLeftX = Convert.ToString(int.Parse(HipCenterX) - PELVIS * _Stature / 2);
            FootLeftY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH + SHANK_LENGTH + ANKLE_HEIGHT) * _Stature);

            FootRightX = Convert.ToString(int.Parse(HipCenterX) + PELVIS * _Stature / 2);
            FootRightY = Convert.ToString(int.Parse(HipCenterY) + (BUTTOCKS_HEIGHT + THIGH_LENGTH + SHANK_LENGTH + ANKLE_HEIGHT) * _Stature);
        }
    }
}
