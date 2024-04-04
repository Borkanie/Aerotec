// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Microsoft.VisualBasic;

namespace Jet3UpHelpers.Factories
{
    public class Jet3UpMessageBuilder
    {
        private static Jet3UpMessageBuilder instance;
        private FontSizeEnum size;
        private MachineTypeEnum machineType;
        private string message = "";

        private Jet3UpMessageBuilder()
        {
            
        }

        public static Jet3UpMessageBuilder Start()
        {
            instance = new Jet3UpMessageBuilder();
            return instance;
        }

        private int[] GetLocation(FontSizeEnum size, MachineTypeEnum machineType)
        {
            switch (machineType)
            {
                case MachineTypeEnum.Alba:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return new int[] { 0, 107, 0, 70, 98 };
                        case FontSizeEnum.ISO1_7x5:
                            return new int[] { 0, 172, 0, 114, 158 };
                        case FontSizeEnum.ISO1_9x7:
                            return new int[] { 0, 242, 0, 162, 222 };
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                case MachineTypeEnum.Neagra:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return new int[] { 0, 92, 0, 60, 80 };
                        case FontSizeEnum.ISO1_7x5:
                            return new int[] { 0, 92, 0, 60, 82 };
                        case FontSizeEnum.ISO1_9x7:
                            return new int[] { 0, 128, 0, 84, 120 };
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(machineType));
            }
        }

        private string GetBold(FontSizeEnum size, MachineTypeEnum machineType)
        {
            switch(machineType)
            {
                case MachineTypeEnum.Alba:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "1 0 1";
                        case FontSizeEnum.ISO1_7x5:
                            return "1 1 2";
                        case FontSizeEnum.ISO1_9x7:
                            return "1 1 2";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                case MachineTypeEnum.Neagra:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "1 0 0";
                        case FontSizeEnum.ISO1_7x5:
                            return "1 0 0";
                        case FontSizeEnum.ISO1_9x7:
                            return "1 0 1";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(machineType));
            }            
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId)
        {
            var location = GetLocation(size, machineType);
            switch (size)
            {
                
                case FontSizeEnum.ISO1_5x3:
                    message += $"^0*OBJ [1 {location[0]} 11 0 (ISO1_7x5)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 11 0 (ISO1_7x5)  ({signature}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 0 0 (ISO1_7x5)  ({ANR}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 0 0 (ISO1_7x5)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 0 0 (ISO1_7x5)  ({controllerId}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;

                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += $"^0*OBJ [1 {location[0]} 13 0 (ISO1_7x5)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 13 0 (ISO1_7x5)  ({signature}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 0 0 (ISO1_7x5)  ({ANR}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 0 0 (ISO1_7x5)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 0 0 (ISO1_7x5)  ({controllerId}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += $"^0*OBJ [1 {location[0]} 16 0 (ISO1_9x7)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 16 0 (ISO1_9x7)  ({signature}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 0 0 (ISO1_9x7)  ({ANR}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 0 0 (ISO1_9x7)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 0 0 (ISO1_9x7)  ({controllerId}) 1 0 0 0 0 {GetBold(size, machineType)} 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;
                    break;
                default:

                    break;
            }
            return this;
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId, string final)
        {
            var location = GetLocation(size, machineType);
            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += $"^0*OBJ [1 {location[0]} 22 0 (ISO1_7x5)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 22 0 (ISO1_7x5)  ({signature}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 11 0 (ISO1_7x5)  ({ANR}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 11 0 (ISO1_7x5)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 11 0 (ISO1_7x5)  ({controllerId}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [6 0 0 0 (ISO1_7x5)  ({final}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += $"^0*OBJ [1 {location[0]} 24 0 (ISO1_7x5)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 24 0 (ISO1_7x5)  ({signature} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 12 0 (ISO1_7x5)  ({ANR}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 12 0 (ISO1_7x5)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 12 0 (ISO1_7x5)  ({controllerId}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [6 0 0 0 (ISO1_7x5)  ({final}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;


                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += $"^0*OBJ [1 {location[0]} 32 0 (ISO1_9x7)  ({HTZ} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [2 {location[1]} 32 0 (ISO1_9x7)  ({signature} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [3 {location[2]} 16 0 (ISO1_9x7)  ({ANR}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [4 {location[3]} 16 0 (ISO1_9x7)  ({BTIDX} ) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [5 {location[4]} 16 0 (ISO1_9x7)  ({controllerId}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + $"^0*OBJ [6 0 0 0 (ISO1_9x7)  ({final}) 1 0 0 0 0 {GetBold(size, MachineTypeEnum.Neagra)} 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;

                    break;
                default:

                    break;
            }
            return this;
        }

        private string GetDistanceBetweenDots(FontSizeEnum size, MachineTypeEnum machineType)
        {
            switch (machineType)
            {
                case MachineTypeEnum.Alba:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "320";
                        case FontSizeEnum.ISO1_7x5:
                            return "380";
                        case FontSizeEnum.ISO1_9x7:
                            return "420";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                case MachineTypeEnum.Neagra:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "220";
                        case FontSizeEnum.ISO1_7x5:
                            return "320";
                        case FontSizeEnum.ISO1_9x7:
                            return "380";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(machineType));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="delay">Print go delay in micro meters</param>
        /// <param name="size"></param>
        /// <param name="rotation"></param>
        /// <param name="machineType"></param>
        /// <param name="printGoSignal"></param>
        /// <param name="encoderSignal"></param>
        /// <param name="encoderSpeed"></param>
        /// <param name="encoderResolution"></param>
        /// <returns></returns>
        public Jet3UpMessageBuilder SetSize(FontSizeEnum size,int rotation, MachineTypeEnum machineType, int delay = 2000, int printGoSignal = 0, int encoderSignal = 0, int encoderSpeed = 10, int encoderResolution = 700)
        {
            this.size = size;
            this.machineType = machineType;
            var mirrored = machineType == MachineTypeEnum.Alba ? 0 : 1;
            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 60 1 0 3 1000 {rotation} 0 30000 00:00 0 30000 0 0 1000]" + Constants.vbCrLf
                            + $"^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + $"^0*JOBPAR [ {delay} 0 0 {GetDistanceBetweenDots(size, machineType)} 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 {rotation} 0 30000 00:00 0 30000 0 0 1000]" + Constants.vbCrLf
                            + $"^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + $"^0*JOBPAR [ {delay} 0 0 {GetDistanceBetweenDots(size, machineType)} 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 {rotation} 0 30000 00:00 0 30000 0 0 1000]" + Constants.vbCrLf
                            + $"^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + $"^0*JOBPAR [  {delay}  0 0 {GetDistanceBetweenDots(size, machineType)} 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
                    break;
                default:

                    break;
            }
            return this;

        }

        public Jet3UpMessageBuilder Create()
        {
            message += "";
                //"^0*ENDJOB []{Constants.vbCrLf}^0*ENDLJSCRIPT []" + Constants.vbCrLf;
            return this;
        }

        public string End()
        {
            message += "^0*ENDJOB []" + Constants.vbCrLf
                    + $"^0*ENDLJSCRIPT []" + Constants.vbCrLf;
            return message;
        }
    }
}
