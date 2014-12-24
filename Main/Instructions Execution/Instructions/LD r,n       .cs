﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "LD r,n       .tt" instead.


using System;

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LD A,n instruction.
        /// </summary>
        byte LD_A_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.A = value;
            return 7;
        }

        /// <summary>
        /// The LD B,n instruction.
        /// </summary>
        byte LD_B_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.B = value;
            return 7;
        }

        /// <summary>
        /// The LD C,n instruction.
        /// </summary>
        byte LD_C_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.C = value;
            return 7;
        }

        /// <summary>
        /// The LD D,n instruction.
        /// </summary>
        byte LD_D_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.D = value;
            return 7;
        }

        /// <summary>
        /// The LD E,n instruction.
        /// </summary>
        byte LD_E_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.E = value;
            return 7;
        }

        /// <summary>
        /// The LD H,n instruction.
        /// </summary>
        byte LD_H_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.H = value;
            return 7;
        }

        /// <summary>
        /// The LD L,n instruction.
        /// </summary>
        byte LD_L_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.L = value;
            return 7;
        }

        /// <summary>
        /// The LD IXH,n instruction.
        /// </summary>
        byte LD_IXH_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.IXH = value;
            return 11;
        }

        /// <summary>
        /// The LD IXL,n instruction.
        /// </summary>
        byte LD_IXL_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.IXL = value;
            return 11;
        }

        /// <summary>
        /// The LD IYH,n instruction.
        /// </summary>
        byte LD_IYH_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.IYH = value;
            return 11;
        }

        /// <summary>
        /// The LD IYL,n instruction.
        /// </summary>
        byte LD_IYL_n()
        {
            var value = ProcessorAgent.FetchNextOpcode();
            FetchFinished();
            Registers.IYL = value;
            return 11;
        }

    }
}
