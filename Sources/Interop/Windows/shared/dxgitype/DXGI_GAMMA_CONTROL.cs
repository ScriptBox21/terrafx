// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgitype.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public /* blittable */ struct DXGI_GAMMA_CONTROL
    {
        #region Fields
        public DXGI_RGB Scale;

        public DXGI_RGB Offset;

        public _GammaCurve_e__FixedBuffer GammaCurve;
        #endregion

        #region Structs
        public /* blittable */ struct _GammaCurve_e__FixedBuffer
        {
            #region Fields
            public DXGI_RGB _0;

            public DXGI_RGB _1;

            public DXGI_RGB _2;

            public DXGI_RGB _3;

            public DXGI_RGB _4;

            public DXGI_RGB _5;

            public DXGI_RGB _6;

            public DXGI_RGB _7;

            public DXGI_RGB _8;

            public DXGI_RGB _9;

            public DXGI_RGB _10;

            public DXGI_RGB _11;

            public DXGI_RGB _12;

            public DXGI_RGB _13;

            public DXGI_RGB _14;

            public DXGI_RGB _15;

            public DXGI_RGB _16;

            public DXGI_RGB _17;

            public DXGI_RGB _18;

            public DXGI_RGB _19;

            public DXGI_RGB _20;

            public DXGI_RGB _21;

            public DXGI_RGB _22;

            public DXGI_RGB _23;

            public DXGI_RGB _24;

            public DXGI_RGB _25;

            public DXGI_RGB _26;

            public DXGI_RGB _27;

            public DXGI_RGB _28;

            public DXGI_RGB _29;

            public DXGI_RGB _30;

            public DXGI_RGB _31;

            public DXGI_RGB _32;

            public DXGI_RGB _33;

            public DXGI_RGB _34;

            public DXGI_RGB _35;

            public DXGI_RGB _36;

            public DXGI_RGB _37;

            public DXGI_RGB _38;

            public DXGI_RGB _39;

            public DXGI_RGB _40;

            public DXGI_RGB _41;

            public DXGI_RGB _42;

            public DXGI_RGB _43;

            public DXGI_RGB _44;

            public DXGI_RGB _45;

            public DXGI_RGB _46;

            public DXGI_RGB _47;

            public DXGI_RGB _48;

            public DXGI_RGB _49;

            public DXGI_RGB _50;

            public DXGI_RGB _51;

            public DXGI_RGB _52;

            public DXGI_RGB _53;

            public DXGI_RGB _54;

            public DXGI_RGB _55;

            public DXGI_RGB _56;

            public DXGI_RGB _57;

            public DXGI_RGB _58;

            public DXGI_RGB _59;

            public DXGI_RGB _60;

            public DXGI_RGB _61;

            public DXGI_RGB _62;

            public DXGI_RGB _63;

            public DXGI_RGB _64;

            public DXGI_RGB _65;

            public DXGI_RGB _66;

            public DXGI_RGB _67;

            public DXGI_RGB _68;

            public DXGI_RGB _69;

            public DXGI_RGB _70;

            public DXGI_RGB _71;

            public DXGI_RGB _72;

            public DXGI_RGB _73;

            public DXGI_RGB _74;

            public DXGI_RGB _75;

            public DXGI_RGB _76;

            public DXGI_RGB _77;

            public DXGI_RGB _78;

            public DXGI_RGB _79;

            public DXGI_RGB _80;

            public DXGI_RGB _81;

            public DXGI_RGB _82;

            public DXGI_RGB _83;

            public DXGI_RGB _84;

            public DXGI_RGB _85;

            public DXGI_RGB _86;

            public DXGI_RGB _87;

            public DXGI_RGB _88;

            public DXGI_RGB _89;

            public DXGI_RGB _90;

            public DXGI_RGB _91;

            public DXGI_RGB _92;

            public DXGI_RGB _93;

            public DXGI_RGB _94;

            public DXGI_RGB _95;

            public DXGI_RGB _96;

            public DXGI_RGB _97;

            public DXGI_RGB _98;

            public DXGI_RGB _99;

            public DXGI_RGB _100;

            public DXGI_RGB _101;

            public DXGI_RGB _102;

            public DXGI_RGB _103;

            public DXGI_RGB _104;

            public DXGI_RGB _105;

            public DXGI_RGB _106;

            public DXGI_RGB _107;

            public DXGI_RGB _108;

            public DXGI_RGB _109;

            public DXGI_RGB _110;

            public DXGI_RGB _111;

            public DXGI_RGB _112;

            public DXGI_RGB _113;

            public DXGI_RGB _114;

            public DXGI_RGB _115;

            public DXGI_RGB _116;

            public DXGI_RGB _117;

            public DXGI_RGB _118;

            public DXGI_RGB _119;

            public DXGI_RGB _120;

            public DXGI_RGB _121;

            public DXGI_RGB _122;

            public DXGI_RGB _123;

            public DXGI_RGB _124;

            public DXGI_RGB _125;

            public DXGI_RGB _126;

            public DXGI_RGB _127;

            public DXGI_RGB _128;

            public DXGI_RGB _129;

            public DXGI_RGB _130;

            public DXGI_RGB _131;

            public DXGI_RGB _132;

            public DXGI_RGB _133;

            public DXGI_RGB _134;

            public DXGI_RGB _135;

            public DXGI_RGB _136;

            public DXGI_RGB _137;

            public DXGI_RGB _138;

            public DXGI_RGB _139;

            public DXGI_RGB _140;

            public DXGI_RGB _141;

            public DXGI_RGB _142;

            public DXGI_RGB _143;

            public DXGI_RGB _144;

            public DXGI_RGB _145;

            public DXGI_RGB _146;

            public DXGI_RGB _147;

            public DXGI_RGB _148;

            public DXGI_RGB _149;

            public DXGI_RGB _150;

            public DXGI_RGB _151;

            public DXGI_RGB _152;

            public DXGI_RGB _153;

            public DXGI_RGB _154;

            public DXGI_RGB _155;

            public DXGI_RGB _156;

            public DXGI_RGB _157;

            public DXGI_RGB _158;

            public DXGI_RGB _159;

            public DXGI_RGB _160;

            public DXGI_RGB _161;

            public DXGI_RGB _162;

            public DXGI_RGB _163;

            public DXGI_RGB _164;

            public DXGI_RGB _165;

            public DXGI_RGB _166;

            public DXGI_RGB _167;

            public DXGI_RGB _168;

            public DXGI_RGB _169;

            public DXGI_RGB _170;

            public DXGI_RGB _171;

            public DXGI_RGB _172;

            public DXGI_RGB _173;

            public DXGI_RGB _174;

            public DXGI_RGB _175;

            public DXGI_RGB _176;

            public DXGI_RGB _177;

            public DXGI_RGB _178;

            public DXGI_RGB _179;

            public DXGI_RGB _180;

            public DXGI_RGB _181;

            public DXGI_RGB _182;

            public DXGI_RGB _183;

            public DXGI_RGB _184;

            public DXGI_RGB _185;

            public DXGI_RGB _186;

            public DXGI_RGB _187;

            public DXGI_RGB _188;

            public DXGI_RGB _189;

            public DXGI_RGB _190;

            public DXGI_RGB _191;

            public DXGI_RGB _192;

            public DXGI_RGB _193;

            public DXGI_RGB _194;

            public DXGI_RGB _195;

            public DXGI_RGB _196;

            public DXGI_RGB _197;

            public DXGI_RGB _198;

            public DXGI_RGB _199;

            public DXGI_RGB _200;

            public DXGI_RGB _201;

            public DXGI_RGB _202;

            public DXGI_RGB _203;

            public DXGI_RGB _204;

            public DXGI_RGB _205;

            public DXGI_RGB _206;

            public DXGI_RGB _207;

            public DXGI_RGB _208;

            public DXGI_RGB _209;

            public DXGI_RGB _210;

            public DXGI_RGB _211;

            public DXGI_RGB _212;

            public DXGI_RGB _213;

            public DXGI_RGB _214;

            public DXGI_RGB _215;

            public DXGI_RGB _216;

            public DXGI_RGB _217;

            public DXGI_RGB _218;

            public DXGI_RGB _219;

            public DXGI_RGB _220;

            public DXGI_RGB _221;

            public DXGI_RGB _222;

            public DXGI_RGB _223;

            public DXGI_RGB _224;

            public DXGI_RGB _225;

            public DXGI_RGB _226;

            public DXGI_RGB _227;

            public DXGI_RGB _228;

            public DXGI_RGB _229;

            public DXGI_RGB _230;

            public DXGI_RGB _231;

            public DXGI_RGB _232;

            public DXGI_RGB _233;

            public DXGI_RGB _234;

            public DXGI_RGB _235;

            public DXGI_RGB _236;

            public DXGI_RGB _237;

            public DXGI_RGB _238;

            public DXGI_RGB _239;

            public DXGI_RGB _240;

            public DXGI_RGB _241;

            public DXGI_RGB _242;

            public DXGI_RGB _243;

            public DXGI_RGB _244;

            public DXGI_RGB _245;

            public DXGI_RGB _246;

            public DXGI_RGB _247;

            public DXGI_RGB _248;

            public DXGI_RGB _249;

            public DXGI_RGB _250;

            public DXGI_RGB _251;

            public DXGI_RGB _252;

            public DXGI_RGB _253;

            public DXGI_RGB _254;

            public DXGI_RGB _255;

            public DXGI_RGB _256;

            public DXGI_RGB _257;

            public DXGI_RGB _258;

            public DXGI_RGB _259;

            public DXGI_RGB _260;

            public DXGI_RGB _261;

            public DXGI_RGB _262;

            public DXGI_RGB _263;

            public DXGI_RGB _264;

            public DXGI_RGB _265;

            public DXGI_RGB _266;

            public DXGI_RGB _267;

            public DXGI_RGB _268;

            public DXGI_RGB _269;

            public DXGI_RGB _270;

            public DXGI_RGB _271;

            public DXGI_RGB _272;

            public DXGI_RGB _273;

            public DXGI_RGB _274;

            public DXGI_RGB _275;

            public DXGI_RGB _276;

            public DXGI_RGB _277;

            public DXGI_RGB _278;

            public DXGI_RGB _279;

            public DXGI_RGB _280;

            public DXGI_RGB _281;

            public DXGI_RGB _282;

            public DXGI_RGB _283;

            public DXGI_RGB _284;

            public DXGI_RGB _285;

            public DXGI_RGB _286;

            public DXGI_RGB _287;

            public DXGI_RGB _288;

            public DXGI_RGB _289;

            public DXGI_RGB _290;

            public DXGI_RGB _291;

            public DXGI_RGB _292;

            public DXGI_RGB _293;

            public DXGI_RGB _294;

            public DXGI_RGB _295;

            public DXGI_RGB _296;

            public DXGI_RGB _297;

            public DXGI_RGB _298;

            public DXGI_RGB _299;

            public DXGI_RGB _300;

            public DXGI_RGB _301;

            public DXGI_RGB _302;

            public DXGI_RGB _303;

            public DXGI_RGB _304;

            public DXGI_RGB _305;

            public DXGI_RGB _306;

            public DXGI_RGB _307;

            public DXGI_RGB _308;

            public DXGI_RGB _309;

            public DXGI_RGB _310;

            public DXGI_RGB _311;

            public DXGI_RGB _312;

            public DXGI_RGB _313;

            public DXGI_RGB _314;

            public DXGI_RGB _315;

            public DXGI_RGB _316;

            public DXGI_RGB _317;

            public DXGI_RGB _318;

            public DXGI_RGB _319;

            public DXGI_RGB _320;

            public DXGI_RGB _321;

            public DXGI_RGB _322;

            public DXGI_RGB _323;

            public DXGI_RGB _324;

            public DXGI_RGB _325;

            public DXGI_RGB _326;

            public DXGI_RGB _327;

            public DXGI_RGB _328;

            public DXGI_RGB _329;

            public DXGI_RGB _330;

            public DXGI_RGB _331;

            public DXGI_RGB _332;

            public DXGI_RGB _333;

            public DXGI_RGB _334;

            public DXGI_RGB _335;

            public DXGI_RGB _336;

            public DXGI_RGB _337;

            public DXGI_RGB _338;

            public DXGI_RGB _339;

            public DXGI_RGB _340;

            public DXGI_RGB _341;

            public DXGI_RGB _342;

            public DXGI_RGB _343;

            public DXGI_RGB _344;

            public DXGI_RGB _345;

            public DXGI_RGB _346;

            public DXGI_RGB _347;

            public DXGI_RGB _348;

            public DXGI_RGB _349;

            public DXGI_RGB _350;

            public DXGI_RGB _351;

            public DXGI_RGB _352;

            public DXGI_RGB _353;

            public DXGI_RGB _354;

            public DXGI_RGB _355;

            public DXGI_RGB _356;

            public DXGI_RGB _357;

            public DXGI_RGB _358;

            public DXGI_RGB _359;

            public DXGI_RGB _360;

            public DXGI_RGB _361;

            public DXGI_RGB _362;

            public DXGI_RGB _363;

            public DXGI_RGB _364;

            public DXGI_RGB _365;

            public DXGI_RGB _366;

            public DXGI_RGB _367;

            public DXGI_RGB _368;

            public DXGI_RGB _369;

            public DXGI_RGB _370;

            public DXGI_RGB _371;

            public DXGI_RGB _372;

            public DXGI_RGB _373;

            public DXGI_RGB _374;

            public DXGI_RGB _375;

            public DXGI_RGB _376;

            public DXGI_RGB _377;

            public DXGI_RGB _378;

            public DXGI_RGB _379;

            public DXGI_RGB _380;

            public DXGI_RGB _381;

            public DXGI_RGB _382;

            public DXGI_RGB _383;

            public DXGI_RGB _384;

            public DXGI_RGB _385;

            public DXGI_RGB _386;

            public DXGI_RGB _387;

            public DXGI_RGB _388;

            public DXGI_RGB _389;

            public DXGI_RGB _390;

            public DXGI_RGB _391;

            public DXGI_RGB _392;

            public DXGI_RGB _393;

            public DXGI_RGB _394;

            public DXGI_RGB _395;

            public DXGI_RGB _396;

            public DXGI_RGB _397;

            public DXGI_RGB _398;

            public DXGI_RGB _399;

            public DXGI_RGB _400;

            public DXGI_RGB _401;

            public DXGI_RGB _402;

            public DXGI_RGB _403;

            public DXGI_RGB _404;

            public DXGI_RGB _405;

            public DXGI_RGB _406;

            public DXGI_RGB _407;

            public DXGI_RGB _408;

            public DXGI_RGB _409;

            public DXGI_RGB _410;

            public DXGI_RGB _411;

            public DXGI_RGB _412;

            public DXGI_RGB _413;

            public DXGI_RGB _414;

            public DXGI_RGB _415;

            public DXGI_RGB _416;

            public DXGI_RGB _417;

            public DXGI_RGB _418;

            public DXGI_RGB _419;

            public DXGI_RGB _420;

            public DXGI_RGB _421;

            public DXGI_RGB _422;

            public DXGI_RGB _423;

            public DXGI_RGB _424;

            public DXGI_RGB _425;

            public DXGI_RGB _426;

            public DXGI_RGB _427;

            public DXGI_RGB _428;

            public DXGI_RGB _429;

            public DXGI_RGB _430;

            public DXGI_RGB _431;

            public DXGI_RGB _432;

            public DXGI_RGB _433;

            public DXGI_RGB _434;

            public DXGI_RGB _435;

            public DXGI_RGB _436;

            public DXGI_RGB _437;

            public DXGI_RGB _438;

            public DXGI_RGB _439;

            public DXGI_RGB _440;

            public DXGI_RGB _441;

            public DXGI_RGB _442;

            public DXGI_RGB _443;

            public DXGI_RGB _444;

            public DXGI_RGB _445;

            public DXGI_RGB _446;

            public DXGI_RGB _447;

            public DXGI_RGB _448;

            public DXGI_RGB _449;

            public DXGI_RGB _450;

            public DXGI_RGB _451;

            public DXGI_RGB _452;

            public DXGI_RGB _453;

            public DXGI_RGB _454;

            public DXGI_RGB _455;

            public DXGI_RGB _456;

            public DXGI_RGB _457;

            public DXGI_RGB _458;

            public DXGI_RGB _459;

            public DXGI_RGB _460;

            public DXGI_RGB _461;

            public DXGI_RGB _462;

            public DXGI_RGB _463;

            public DXGI_RGB _464;

            public DXGI_RGB _465;

            public DXGI_RGB _466;

            public DXGI_RGB _467;

            public DXGI_RGB _468;

            public DXGI_RGB _469;

            public DXGI_RGB _470;

            public DXGI_RGB _471;

            public DXGI_RGB _472;

            public DXGI_RGB _473;

            public DXGI_RGB _474;

            public DXGI_RGB _475;

            public DXGI_RGB _476;

            public DXGI_RGB _477;

            public DXGI_RGB _478;

            public DXGI_RGB _479;

            public DXGI_RGB _480;

            public DXGI_RGB _481;

            public DXGI_RGB _482;

            public DXGI_RGB _483;

            public DXGI_RGB _484;

            public DXGI_RGB _485;

            public DXGI_RGB _486;

            public DXGI_RGB _487;

            public DXGI_RGB _488;

            public DXGI_RGB _489;

            public DXGI_RGB _490;

            public DXGI_RGB _491;

            public DXGI_RGB _492;

            public DXGI_RGB _493;

            public DXGI_RGB _494;

            public DXGI_RGB _495;

            public DXGI_RGB _496;

            public DXGI_RGB _497;

            public DXGI_RGB _498;

            public DXGI_RGB _499;

            public DXGI_RGB _500;

            public DXGI_RGB _501;

            public DXGI_RGB _502;

            public DXGI_RGB _503;

            public DXGI_RGB _504;

            public DXGI_RGB _505;

            public DXGI_RGB _506;

            public DXGI_RGB _507;

            public DXGI_RGB _508;

            public DXGI_RGB _509;

            public DXGI_RGB _510;

            public DXGI_RGB _511;

            public DXGI_RGB _512;

            public DXGI_RGB _513;

            public DXGI_RGB _514;

            public DXGI_RGB _515;

            public DXGI_RGB _516;

            public DXGI_RGB _517;

            public DXGI_RGB _518;

            public DXGI_RGB _519;

            public DXGI_RGB _520;

            public DXGI_RGB _521;

            public DXGI_RGB _522;

            public DXGI_RGB _523;

            public DXGI_RGB _524;

            public DXGI_RGB _525;

            public DXGI_RGB _526;

            public DXGI_RGB _527;

            public DXGI_RGB _528;

            public DXGI_RGB _529;

            public DXGI_RGB _530;

            public DXGI_RGB _531;

            public DXGI_RGB _532;

            public DXGI_RGB _533;

            public DXGI_RGB _534;

            public DXGI_RGB _535;

            public DXGI_RGB _536;

            public DXGI_RGB _537;

            public DXGI_RGB _538;

            public DXGI_RGB _539;

            public DXGI_RGB _540;

            public DXGI_RGB _541;

            public DXGI_RGB _542;

            public DXGI_RGB _543;

            public DXGI_RGB _544;

            public DXGI_RGB _545;

            public DXGI_RGB _546;

            public DXGI_RGB _547;

            public DXGI_RGB _548;

            public DXGI_RGB _549;

            public DXGI_RGB _550;

            public DXGI_RGB _551;

            public DXGI_RGB _552;

            public DXGI_RGB _553;

            public DXGI_RGB _554;

            public DXGI_RGB _555;

            public DXGI_RGB _556;

            public DXGI_RGB _557;

            public DXGI_RGB _558;

            public DXGI_RGB _559;

            public DXGI_RGB _560;

            public DXGI_RGB _561;

            public DXGI_RGB _562;

            public DXGI_RGB _563;

            public DXGI_RGB _564;

            public DXGI_RGB _565;

            public DXGI_RGB _566;

            public DXGI_RGB _567;

            public DXGI_RGB _568;

            public DXGI_RGB _569;

            public DXGI_RGB _570;

            public DXGI_RGB _571;

            public DXGI_RGB _572;

            public DXGI_RGB _573;

            public DXGI_RGB _574;

            public DXGI_RGB _575;

            public DXGI_RGB _576;

            public DXGI_RGB _577;

            public DXGI_RGB _578;

            public DXGI_RGB _579;

            public DXGI_RGB _580;

            public DXGI_RGB _581;

            public DXGI_RGB _582;

            public DXGI_RGB _583;

            public DXGI_RGB _584;

            public DXGI_RGB _585;

            public DXGI_RGB _586;

            public DXGI_RGB _587;

            public DXGI_RGB _588;

            public DXGI_RGB _589;

            public DXGI_RGB _590;

            public DXGI_RGB _591;

            public DXGI_RGB _592;

            public DXGI_RGB _593;

            public DXGI_RGB _594;

            public DXGI_RGB _595;

            public DXGI_RGB _596;

            public DXGI_RGB _597;

            public DXGI_RGB _598;

            public DXGI_RGB _599;

            public DXGI_RGB _600;

            public DXGI_RGB _601;

            public DXGI_RGB _602;

            public DXGI_RGB _603;

            public DXGI_RGB _604;

            public DXGI_RGB _605;

            public DXGI_RGB _606;

            public DXGI_RGB _607;

            public DXGI_RGB _608;

            public DXGI_RGB _609;

            public DXGI_RGB _610;

            public DXGI_RGB _611;

            public DXGI_RGB _612;

            public DXGI_RGB _613;

            public DXGI_RGB _614;

            public DXGI_RGB _615;

            public DXGI_RGB _616;

            public DXGI_RGB _617;

            public DXGI_RGB _618;

            public DXGI_RGB _619;

            public DXGI_RGB _620;

            public DXGI_RGB _621;

            public DXGI_RGB _622;

            public DXGI_RGB _623;

            public DXGI_RGB _624;

            public DXGI_RGB _625;

            public DXGI_RGB _626;

            public DXGI_RGB _627;

            public DXGI_RGB _628;

            public DXGI_RGB _629;

            public DXGI_RGB _630;

            public DXGI_RGB _631;

            public DXGI_RGB _632;

            public DXGI_RGB _633;

            public DXGI_RGB _634;

            public DXGI_RGB _635;

            public DXGI_RGB _636;

            public DXGI_RGB _637;

            public DXGI_RGB _638;

            public DXGI_RGB _639;

            public DXGI_RGB _640;

            public DXGI_RGB _641;

            public DXGI_RGB _642;

            public DXGI_RGB _643;

            public DXGI_RGB _644;

            public DXGI_RGB _645;

            public DXGI_RGB _646;

            public DXGI_RGB _647;

            public DXGI_RGB _648;

            public DXGI_RGB _649;

            public DXGI_RGB _650;

            public DXGI_RGB _651;

            public DXGI_RGB _652;

            public DXGI_RGB _653;

            public DXGI_RGB _654;

            public DXGI_RGB _655;

            public DXGI_RGB _656;

            public DXGI_RGB _657;

            public DXGI_RGB _658;

            public DXGI_RGB _659;

            public DXGI_RGB _660;

            public DXGI_RGB _661;

            public DXGI_RGB _662;

            public DXGI_RGB _663;

            public DXGI_RGB _664;

            public DXGI_RGB _665;

            public DXGI_RGB _666;

            public DXGI_RGB _667;

            public DXGI_RGB _668;

            public DXGI_RGB _669;

            public DXGI_RGB _670;

            public DXGI_RGB _671;

            public DXGI_RGB _672;

            public DXGI_RGB _673;

            public DXGI_RGB _674;

            public DXGI_RGB _675;

            public DXGI_RGB _676;

            public DXGI_RGB _677;

            public DXGI_RGB _678;

            public DXGI_RGB _679;

            public DXGI_RGB _680;

            public DXGI_RGB _681;

            public DXGI_RGB _682;

            public DXGI_RGB _683;

            public DXGI_RGB _684;

            public DXGI_RGB _685;

            public DXGI_RGB _686;

            public DXGI_RGB _687;

            public DXGI_RGB _688;

            public DXGI_RGB _689;

            public DXGI_RGB _690;

            public DXGI_RGB _691;

            public DXGI_RGB _692;

            public DXGI_RGB _693;

            public DXGI_RGB _694;

            public DXGI_RGB _695;

            public DXGI_RGB _696;

            public DXGI_RGB _697;

            public DXGI_RGB _698;

            public DXGI_RGB _699;

            public DXGI_RGB _700;

            public DXGI_RGB _701;

            public DXGI_RGB _702;

            public DXGI_RGB _703;

            public DXGI_RGB _704;

            public DXGI_RGB _705;

            public DXGI_RGB _706;

            public DXGI_RGB _707;

            public DXGI_RGB _708;

            public DXGI_RGB _709;

            public DXGI_RGB _710;

            public DXGI_RGB _711;

            public DXGI_RGB _712;

            public DXGI_RGB _713;

            public DXGI_RGB _714;

            public DXGI_RGB _715;

            public DXGI_RGB _716;

            public DXGI_RGB _717;

            public DXGI_RGB _718;

            public DXGI_RGB _719;

            public DXGI_RGB _720;

            public DXGI_RGB _721;

            public DXGI_RGB _722;

            public DXGI_RGB _723;

            public DXGI_RGB _724;

            public DXGI_RGB _725;

            public DXGI_RGB _726;

            public DXGI_RGB _727;

            public DXGI_RGB _728;

            public DXGI_RGB _729;

            public DXGI_RGB _730;

            public DXGI_RGB _731;

            public DXGI_RGB _732;

            public DXGI_RGB _733;

            public DXGI_RGB _734;

            public DXGI_RGB _735;

            public DXGI_RGB _736;

            public DXGI_RGB _737;

            public DXGI_RGB _738;

            public DXGI_RGB _739;

            public DXGI_RGB _740;

            public DXGI_RGB _741;

            public DXGI_RGB _742;

            public DXGI_RGB _743;

            public DXGI_RGB _744;

            public DXGI_RGB _745;

            public DXGI_RGB _746;

            public DXGI_RGB _747;

            public DXGI_RGB _748;

            public DXGI_RGB _749;

            public DXGI_RGB _750;

            public DXGI_RGB _751;

            public DXGI_RGB _752;

            public DXGI_RGB _753;

            public DXGI_RGB _754;

            public DXGI_RGB _755;

            public DXGI_RGB _756;

            public DXGI_RGB _757;

            public DXGI_RGB _758;

            public DXGI_RGB _759;

            public DXGI_RGB _760;

            public DXGI_RGB _761;

            public DXGI_RGB _762;

            public DXGI_RGB _763;

            public DXGI_RGB _764;

            public DXGI_RGB _765;

            public DXGI_RGB _766;

            public DXGI_RGB _767;

            public DXGI_RGB _768;

            public DXGI_RGB _769;

            public DXGI_RGB _770;

            public DXGI_RGB _771;

            public DXGI_RGB _772;

            public DXGI_RGB _773;

            public DXGI_RGB _774;

            public DXGI_RGB _775;

            public DXGI_RGB _776;

            public DXGI_RGB _777;

            public DXGI_RGB _778;

            public DXGI_RGB _779;

            public DXGI_RGB _780;

            public DXGI_RGB _781;

            public DXGI_RGB _782;

            public DXGI_RGB _783;

            public DXGI_RGB _784;

            public DXGI_RGB _785;

            public DXGI_RGB _786;

            public DXGI_RGB _787;

            public DXGI_RGB _788;

            public DXGI_RGB _789;

            public DXGI_RGB _790;

            public DXGI_RGB _791;

            public DXGI_RGB _792;

            public DXGI_RGB _793;

            public DXGI_RGB _794;

            public DXGI_RGB _795;

            public DXGI_RGB _796;

            public DXGI_RGB _797;

            public DXGI_RGB _798;

            public DXGI_RGB _799;

            public DXGI_RGB _800;

            public DXGI_RGB _801;

            public DXGI_RGB _802;

            public DXGI_RGB _803;

            public DXGI_RGB _804;

            public DXGI_RGB _805;

            public DXGI_RGB _806;

            public DXGI_RGB _807;

            public DXGI_RGB _808;

            public DXGI_RGB _809;

            public DXGI_RGB _810;

            public DXGI_RGB _811;

            public DXGI_RGB _812;

            public DXGI_RGB _813;

            public DXGI_RGB _814;

            public DXGI_RGB _815;

            public DXGI_RGB _816;

            public DXGI_RGB _817;

            public DXGI_RGB _818;

            public DXGI_RGB _819;

            public DXGI_RGB _820;

            public DXGI_RGB _821;

            public DXGI_RGB _822;

            public DXGI_RGB _823;

            public DXGI_RGB _824;

            public DXGI_RGB _825;

            public DXGI_RGB _826;

            public DXGI_RGB _827;

            public DXGI_RGB _828;

            public DXGI_RGB _829;

            public DXGI_RGB _830;

            public DXGI_RGB _831;

            public DXGI_RGB _832;

            public DXGI_RGB _833;

            public DXGI_RGB _834;

            public DXGI_RGB _835;

            public DXGI_RGB _836;

            public DXGI_RGB _837;

            public DXGI_RGB _838;

            public DXGI_RGB _839;

            public DXGI_RGB _840;

            public DXGI_RGB _841;

            public DXGI_RGB _842;

            public DXGI_RGB _843;

            public DXGI_RGB _844;

            public DXGI_RGB _845;

            public DXGI_RGB _846;

            public DXGI_RGB _847;

            public DXGI_RGB _848;

            public DXGI_RGB _849;

            public DXGI_RGB _850;

            public DXGI_RGB _851;

            public DXGI_RGB _852;

            public DXGI_RGB _853;

            public DXGI_RGB _854;

            public DXGI_RGB _855;

            public DXGI_RGB _856;

            public DXGI_RGB _857;

            public DXGI_RGB _858;

            public DXGI_RGB _859;

            public DXGI_RGB _860;

            public DXGI_RGB _861;

            public DXGI_RGB _862;

            public DXGI_RGB _863;

            public DXGI_RGB _864;

            public DXGI_RGB _865;

            public DXGI_RGB _866;

            public DXGI_RGB _867;

            public DXGI_RGB _868;

            public DXGI_RGB _869;

            public DXGI_RGB _870;

            public DXGI_RGB _871;

            public DXGI_RGB _872;

            public DXGI_RGB _873;

            public DXGI_RGB _874;

            public DXGI_RGB _875;

            public DXGI_RGB _876;

            public DXGI_RGB _877;

            public DXGI_RGB _878;

            public DXGI_RGB _879;

            public DXGI_RGB _880;

            public DXGI_RGB _881;

            public DXGI_RGB _882;

            public DXGI_RGB _883;

            public DXGI_RGB _884;

            public DXGI_RGB _885;

            public DXGI_RGB _886;

            public DXGI_RGB _887;

            public DXGI_RGB _888;

            public DXGI_RGB _889;

            public DXGI_RGB _890;

            public DXGI_RGB _891;

            public DXGI_RGB _892;

            public DXGI_RGB _893;

            public DXGI_RGB _894;

            public DXGI_RGB _895;

            public DXGI_RGB _896;

            public DXGI_RGB _897;

            public DXGI_RGB _898;

            public DXGI_RGB _899;

            public DXGI_RGB _900;

            public DXGI_RGB _901;

            public DXGI_RGB _902;

            public DXGI_RGB _903;

            public DXGI_RGB _904;

            public DXGI_RGB _905;

            public DXGI_RGB _906;

            public DXGI_RGB _907;

            public DXGI_RGB _908;

            public DXGI_RGB _909;

            public DXGI_RGB _910;

            public DXGI_RGB _911;

            public DXGI_RGB _912;

            public DXGI_RGB _913;

            public DXGI_RGB _914;

            public DXGI_RGB _915;

            public DXGI_RGB _916;

            public DXGI_RGB _917;

            public DXGI_RGB _918;

            public DXGI_RGB _919;

            public DXGI_RGB _920;

            public DXGI_RGB _921;

            public DXGI_RGB _922;

            public DXGI_RGB _923;

            public DXGI_RGB _924;

            public DXGI_RGB _925;

            public DXGI_RGB _926;

            public DXGI_RGB _927;

            public DXGI_RGB _928;

            public DXGI_RGB _929;

            public DXGI_RGB _930;

            public DXGI_RGB _931;

            public DXGI_RGB _932;

            public DXGI_RGB _933;

            public DXGI_RGB _934;

            public DXGI_RGB _935;

            public DXGI_RGB _936;

            public DXGI_RGB _937;

            public DXGI_RGB _938;

            public DXGI_RGB _939;

            public DXGI_RGB _940;

            public DXGI_RGB _941;

            public DXGI_RGB _942;

            public DXGI_RGB _943;

            public DXGI_RGB _944;

            public DXGI_RGB _945;

            public DXGI_RGB _946;

            public DXGI_RGB _947;

            public DXGI_RGB _948;

            public DXGI_RGB _949;

            public DXGI_RGB _950;

            public DXGI_RGB _951;

            public DXGI_RGB _952;

            public DXGI_RGB _953;

            public DXGI_RGB _954;

            public DXGI_RGB _955;

            public DXGI_RGB _956;

            public DXGI_RGB _957;

            public DXGI_RGB _958;

            public DXGI_RGB _959;

            public DXGI_RGB _960;

            public DXGI_RGB _961;

            public DXGI_RGB _962;

            public DXGI_RGB _963;

            public DXGI_RGB _964;

            public DXGI_RGB _965;

            public DXGI_RGB _966;

            public DXGI_RGB _967;

            public DXGI_RGB _968;

            public DXGI_RGB _969;

            public DXGI_RGB _970;

            public DXGI_RGB _971;

            public DXGI_RGB _972;

            public DXGI_RGB _973;

            public DXGI_RGB _974;

            public DXGI_RGB _975;

            public DXGI_RGB _976;

            public DXGI_RGB _977;

            public DXGI_RGB _978;

            public DXGI_RGB _979;

            public DXGI_RGB _980;

            public DXGI_RGB _981;

            public DXGI_RGB _982;

            public DXGI_RGB _983;

            public DXGI_RGB _984;

            public DXGI_RGB _985;

            public DXGI_RGB _986;

            public DXGI_RGB _987;

            public DXGI_RGB _988;

            public DXGI_RGB _989;

            public DXGI_RGB _990;

            public DXGI_RGB _991;

            public DXGI_RGB _992;

            public DXGI_RGB _993;

            public DXGI_RGB _994;

            public DXGI_RGB _995;

            public DXGI_RGB _996;

            public DXGI_RGB _997;

            public DXGI_RGB _998;

            public DXGI_RGB _999;

            public DXGI_RGB _1000;

            public DXGI_RGB _1001;

            public DXGI_RGB _1002;

            public DXGI_RGB _1003;

            public DXGI_RGB _1004;

            public DXGI_RGB _1005;

            public DXGI_RGB _1006;

            public DXGI_RGB _1007;

            public DXGI_RGB _1008;

            public DXGI_RGB _1009;

            public DXGI_RGB _1010;

            public DXGI_RGB _1011;

            public DXGI_RGB _1012;

            public DXGI_RGB _1013;

            public DXGI_RGB _1014;

            public DXGI_RGB _1015;

            public DXGI_RGB _1016;

            public DXGI_RGB _1017;

            public DXGI_RGB _1018;

            public DXGI_RGB _1019;

            public DXGI_RGB _1020;

            public DXGI_RGB _1021;

            public DXGI_RGB _1022;

            public DXGI_RGB _1023;

            public DXGI_RGB _1024;
            #endregion
        }
        #endregion
    }
}