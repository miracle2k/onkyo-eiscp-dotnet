// Generated
// by generate.exe
// from eiscp-commands.yaml
// at 2013-01-15 13:55:20

using System.Collections;
using System.Collections.Specialized;

namespace Eiscp.Core
{
	public static class EiscpCommands
	{
		public static readonly OrderedDictionary Commands = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
		{
			{
 				"main",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PWR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"system-power"
							},
							{
 								"description",
								"System Power Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets System Standby"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets System On"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the System Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AMT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audio-muting"
							},
							{
 								"description",
								"Audio Muting Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audio Muting Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Audio Muting On"
											}
										}
									},
									{
 										"TG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Audio Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Audio Muting State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"speaker-a"
							},
							{
 								"description",
								"Speaker A Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Speaker Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Speaker On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"speaker-b"
							},
							{
 								"description",
								"Speaker B Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Speaker Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Speaker On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"speaker-layout"
							},
							{
 								"description",
								"Speaker Layout Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"SB",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"surrback"
											},
											{
 												"description",
												"sets SurrBack Speaker"
											}
										}
									},
									{
 										"FH",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"front-high",
													"surrback-front-high-speakers"
												}
											},
											{
 												"description",
												"sets Front High Speaker / SurrBack+Front High Speakers"
											}
										}
									},
									{
 										"FW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"front-wide",
													"surrback-front-wide-speakers"
												}
											},
											{
 												"description",
												"sets Front Wide Speaker / SurrBack+Front Wide Speakers"
											}
										}
									},
									{
 										"HW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"front-high-front-wide-speakers"
												}
											},
											{
 												"description",
												"sets, Front High+Front Wide Speakers"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"master-volume"
							},
							{
 								"description",
								"Master Volume Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"100"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"0",
											"80"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"UP1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-up-1db-step"
											},
											{
 												"description",
												"sets Volume Level Up 1dB Step"
											}
										}
									},
									{
 										"DOWN1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-down-1db-step"
											},
											{
 												"description",
												"sets Volume Level Down 1dB Step"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-front"
							},
							{
 								"description",
								"Tone(Front) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-front-wide"
							},
							{
 								"description",
								"Tone(Front Wide) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front Wide Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front Wide Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front Wide Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front Wide Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front Wide Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front Wide Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front Wide Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-front-high"
							},
							{
 								"description",
								"Tone(Front High) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front High Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front High Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front High Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front High Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front High Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front High Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front High Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-center"
							},
							{
 								"description",
								"Tone(Center) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Center Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Center Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Center Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Center Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Center Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Center Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Cetner Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-surround"
							},
							{
 								"description",
								"Tone(Surround) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Surround Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Surround Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Surround Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Surround Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Surround Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Surround Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Surround Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-surround-back"
							},
							{
 								"description",
								"Tone(Surround Back) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Surround Back Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Surround Back Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Surround Back Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Surround Back Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Surround Back Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Surround Back Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Surround Back Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone-subwoofer"
							},
							{
 								"description",
								"Tone(Subwoofer) Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Subwoofer Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Subwoofer Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Subwoofer Bass down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Subwoofer Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLP",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sleep-set"
							},
							{
 								"description",
								"Sleep Set Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"90"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"time-1-90min"
											},
											{
 												"description",
												"sets Sleep Time 1 - 90min ( In hexadecimal representation)"
											}
										}
									},
									{
 										"OFF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"time-off"
											},
											{
 												"description",
												"sets Sleep Time Off"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Sleep Time Wrap-Around UP"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Sleep Time"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"speaker-level-calibration"
							},
							{
 								"description",
								"Speaker Level Calibration Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"TEST",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"test"
											},
											{
 												"description",
												"TEST Key"
											}
										}
									},
									{
 										"CHSEL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chsel"
											},
											{
 												"description",
												"CH SEL Key"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SWL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"subwoofer-temporary-level"
							},
							{
 								"description",
								"Subwoofer (temporary) Level Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"-15",
											"0",
											"12"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"15db-0db-12db"
											},
											{
 												"description",
												"sets Subwoofer Level -15dB - 0dB - +12dB"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"center-temporary-level"
							},
							{
 								"description",
								"Center (temporary) Level Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"-12",
											"0",
											"12"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"12db-0db-12db"
											},
											{
 												"description",
												"sets Center Level -12dB - 0dB - +12dB"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DIF",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"display-mode"
							},
							{
 								"description",
								"Display Mode Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"selector-volume"
											},
											{
 												"description",
												"sets Selector + Volume Display Mode"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"selector-listening"
											},
											{
 												"description",
												"sets Selector + Listening Mode Display Mode"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"02"
											},
											{
 												"description",
												"Display Digital Format(temporary display)"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"03"
											},
											{
 												"description",
												"Display Video Format(temporary display)"
											}
										}
									},
									{
 										"TG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Display Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Display Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DIM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dimmer-level"
							},
							{
 								"description",
								"Dimmer Level Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bright"
											},
											{
 												"description",
												"sets Dimmer Level \"Bright\""
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dim"
											},
											{
 												"description",
												"sets Dimmer Level \"Dim\""
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dark"
											},
											{
 												"description",
												"sets Dimmer Level \"Dark\""
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"shut-off"
											},
											{
 												"description",
												"sets Dimmer Level \"Shut-Off\""
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bright-led-off"
											},
											{
 												"description",
												"sets Dimmer Level \"Bright & LED OFF\""
											}
										}
									},
									{
 										"DIM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dim"
											},
											{
 												"description",
												"sets Dimmer Level Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dimmer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"OSD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"setup"
							},
							{
 								"description",
								"Setup Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"MENU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"Menu Key"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"Up Key"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"Down Key"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"Right Key"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"Left Key"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Enter Key"
											}
										}
									},
									{
 										"EXIT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"exit"
											},
											{
 												"description",
												"Exit Key"
											}
										}
									},
									{
 										"AUDIO",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"audio"
											},
											{
 												"description",
												"Audio Adjust Key"
											}
										}
									},
									{
 										"VIDEO",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video"
											},
											{
 												"description",
												"Video Adjust Key"
											}
										}
									},
									{
 										"HOME",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"home"
											},
											{
 												"description",
												"Home Key"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MEM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"memory-setup"
							},
							{
 								"description",
								"Memory Setup Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"STR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"str"
											},
											{
 												"description",
												"stores memory"
											}
										}
									},
									{
 										"RCL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rcl"
											},
											{
 												"description",
												"recalls memory"
											}
										}
									},
									{
 										"LOCK",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"lock"
											},
											{
 												"description",
												"locks memory"
											}
										}
									},
									{
 										"UNLK",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"unlk"
											},
											{
 												"description",
												"unlocks memory"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IFA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audio-infomation"
							},
							{
 								"description",
								"Audio Infomation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn:nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Infomation of Audio(Same Immediate Display \',\' is separator of infomations)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Infomation of Audio"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IFV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"video-infomation"
							},
							{
 								"description",
								"Video Infomation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn:nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"infomation of Video(Same Immediate Display \',\' is separator of infomations)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Infomation of Video"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"input-selector"
							},
							{
 								"description",
								"Input Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video1",
													"vcr",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video3",
													"game",
													"tv",
													"game"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video5",
													"aux2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"07"
											},
											{
 												"description",
												"Hidden1"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"08"
											},
											{
 												"description",
												"Hidden2"
											}
										}
									},
									{
 										"09",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"09"
											},
											{
 												"description",
												"Hidden3"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"dvd",
													"bd",
													"dvd"
												}
											},
											{
 												"description",
												"sets DVD, BD/DVD"
											}
										}
									},
									{
 										"20",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"tape-1",
													"tv",
													"tape"
												}
											},
											{
 												"description",
												"sets TAPE(1), TV/TAPE"
											}
										}
									},
									{
 										"21",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"cd",
													"tv",
													"cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"40",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"recout-selector"
							},
							{
 								"description",
								"RECOUT Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video1"
											},
											{
 												"description",
												"sets VIDEO1"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video2"
											},
											{
 												"description",
												"sets VIDEO2"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video3"
											},
											{
 												"description",
												"sets VIDEO3"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video4"
											},
											{
 												"description",
												"sets VIDEO4"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video5"
											},
											{
 												"description",
												"sets VIDEO5"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video6"
											},
											{
 												"description",
												"sets VIDEO6"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dvd"
											},
											{
 												"description",
												"sets DVD"
											}
										}
									},
									{
 										"20",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"cd"
											},
											{
 												"description",
												"sets CD"
											}
										}
									},
									{
 										"24",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"music-server"
											},
											{
 												"description",
												"sets MUSIC SERVER"
											}
										}
									},
									{
 										"28",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"internet-radio"
											},
											{
 												"description",
												"sets INTERNET RADIO"
											}
										}
									},
									{
 										"30",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"7F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets OFF"
											}
										}
									},
									{
 										"80",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audio-selector"
							},
							{
 								"description",
								"Audio Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets AUTO"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-channel"
											},
											{
 												"description",
												"sets MULTI-CHANNEL"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"analog"
											},
											{
 												"description",
												"sets ANALOG"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ilink"
											},
											{
 												"description",
												"sets iLINK"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hdmi"
											},
											{
 												"description",
												"sets HDMI"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"coax",
													"opt"
												}
											},
											{
 												"description",
												"sets COAX/OPT"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"balance"
											},
											{
 												"description",
												"sets BALANCE"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"arc"
											},
											{
 												"description",
												"sets ARC"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audio Selector Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audio Selector Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"12v-trigger-a"
							},
							{
 								"description",
								"12V Trigger A Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger A Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger A On"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"12v-trigger-b"
							},
							{
 								"description",
								"12V Trigger B Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger B Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger B On"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"12v-trigger-c"
							},
							{
 								"description",
								"12V Trigger C Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger C Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger C On"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VOS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"video-output-selector"
							},
							{
 								"description",
								"Video Output Selector (Japanese Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"d4"
											},
											{
 												"description",
												"sets D4"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"component"
											},
											{
 												"description",
												"sets Component"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HDO",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hdmi-output-selector"
							},
							{
 								"description",
								"HDMI Output Selector"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"no",
													"analog"
												}
											},
											{
 												"description",
												"sets No, Analog"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"yes",
													"out"
												}
											},
											{
 												"description",
												"sets Yes/Out Main, HDMI Main"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"out-sub",
													"sub"
												}
											},
											{
 												"description",
												"sets Out Sub, HDMI Sub"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"both"
												}
											},
											{
 												"description",
												"sets, Both"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"both"
												}
											},
											{
 												"description",
												"sets, Both(Main)"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"both"
												}
											},
											{
 												"description",
												"sets, Both(Sub)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Out Selector Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The HDMI Out Selector"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HAO",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hdmi-audio-out"
							},
							{
 								"description",
								"HDMI Audio Out"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Audio Out Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HDMI Audio Out"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RES",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"monitor-out-resolution"
							},
							{
 								"description",
								"Monitor Out Resolution"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"through"
											},
											{
 												"description",
												"sets Through"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto(HDMI Output Only)"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"480p"
											},
											{
 												"description",
												"sets 480p"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"720p"
											},
											{
 												"description",
												"sets 720p"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1080i"
											},
											{
 												"description",
												"sets 1080i"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1080p"
											},
											{
 												"description",
												"sets 1080p(HDMI Output Only)"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"1080p",
													"24fs"
												}
											},
											{
 												"description",
												"sets 1080p/24fs(HDMI Output Only)"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4k-upcaling"
											},
											{
 												"description",
												"sets 4K Upcaling(HDMI Output Only)"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets Source"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Monitor Out Resolution Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Monitor Out Resolution"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ISF",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"isf-mode"
							},
							{
 								"description",
								"ISF Mode"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"custom"
											},
											{
 												"description",
												"sets ISF Mode Custom"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"day"
											},
											{
 												"description",
												"sets ISF Mode Day"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"night"
											},
											{
 												"description",
												"sets ISF Mode Night"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets ISF Mode State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The ISF Mode State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VWM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"video-wide-mode"
							},
							{
 								"description",
								"Video Wide Mode"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4-3"
											},
											{
 												"description",
												"sets 4:3"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"full"
											},
											{
 												"description",
												"sets Full"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"zoom"
											},
											{
 												"description",
												"sets Zoom"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"zoom"
											},
											{
 												"description",
												"sets Wide Zoom"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"smart-zoom"
											},
											{
 												"description",
												"sets Smart Zoom"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Video Zoom Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Video Zoom Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VPM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"video-picture-mode"
							},
							{
 								"description",
								"Video Picture Mode"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"through"
											},
											{
 												"description",
												"sets Through"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"custom"
											},
											{
 												"description",
												"sets Custom"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"cinema"
											},
											{
 												"description",
												"sets Cinema"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"game"
											},
											{
 												"description",
												"sets Game"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"isf-day"
											},
											{
 												"description",
												"sets ISF Day"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"isf-night"
											},
											{
 												"description",
												"sets ISF Night"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"streaming"
											},
											{
 												"description",
												"sets Streaming"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"sets Direct"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Video Zoom Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Video Zoom Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"listening-mode"
							},
							{
 								"description",
								"Listening Mode Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stereo"
											},
											{
 												"description",
												"sets STEREO"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"sets DIRECT"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"surround"
											},
											{
 												"description",
												"sets SURROUND"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"film",
													"game-rpg"
												}
											},
											{
 												"description",
												"sets FILM, Game-RPG"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"thx"
											},
											{
 												"description",
												"sets THX"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"action",
													"game-action"
												}
											},
											{
 												"description",
												"sets ACTION, Game-Action"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"musical",
													"game-rock"
												}
											},
											{
 												"description",
												"sets MUSICAL, Game-Rock"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mono-movie"
											},
											{
 												"description",
												"sets MONO MOVIE"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"orchestra"
											},
											{
 												"description",
												"sets ORCHESTRA"
											}
										}
									},
									{
 										"09",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"unplugged"
											},
											{
 												"description",
												"sets UNPLUGGED"
											}
										}
									},
									{
 										"0A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"studio-mix"
											},
											{
 												"description",
												"sets STUDIO-MIX"
											}
										}
									},
									{
 										"0B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tv-logic"
											},
											{
 												"description",
												"sets TV LOGIC"
											}
										}
									},
									{
 										"0C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"all-ch-stereo"
											},
											{
 												"description",
												"sets ALL CH STEREO"
											}
										}
									},
									{
 										"0D",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"theater-dimensional"
											},
											{
 												"description",
												"sets THEATER-DIMENSIONAL"
											}
										}
									},
									{
 										"0E",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"enhanced-7",
													"enhance",
													"game-sports"
												}
											},
											{
 												"description",
												"sets ENHANCED 7/ENHANCE, Game-Sports"
											}
										}
									},
									{
 										"0F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mono"
											},
											{
 												"description",
												"sets MONO"
											}
										}
									},
									{
 										"11",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pure-audio"
											},
											{
 												"description",
												"sets PURE AUDIO"
											}
										}
									},
									{
 										"12",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multiplex"
											},
											{
 												"description",
												"sets MULTIPLEX"
											}
										}
									},
									{
 										"13",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"full-mono"
											},
											{
 												"description",
												"sets FULL MONO"
											}
										}
									},
									{
 										"14",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dolby-virtual"
											},
											{
 												"description",
												"sets DOLBY VIRTUAL"
											}
										}
									},
									{
 										"15",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dts-surround-sensation"
											},
											{
 												"description",
												"sets DTS Surround Sensation"
											}
										}
									},
									{
 										"16",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"audyssey-dsx"
											},
											{
 												"description",
												"sets Audyssey DSX"
											}
										}
									},
									{
 										"1F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"whole-house"
											},
											{
 												"description",
												"sets Whole House Mode"
											}
										}
									},
									{
 										"40",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"straight-decode"
											},
											{
 												"description",
												"sets Straight Decode"
											}
										}
									},
									{
 										"41",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dolby-ex"
											},
											{
 												"description",
												"sets Dolby EX"
											}
										}
									},
									{
 										"42",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"thx-cinema"
											},
											{
 												"description",
												"sets THX Cinema"
											}
										}
									},
									{
 										"43",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"thx-surround-ex"
											},
											{
 												"description",
												"sets THX Surround EX"
											}
										}
									},
									{
 										"44",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"thx-music"
											},
											{
 												"description",
												"sets THX Music"
											}
										}
									},
									{
 										"45",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"thx-games"
											},
											{
 												"description",
												"sets THX Games"
											}
										}
									},
									{
 										"50",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"thx-u2",
													"s2",
													"i",
													"s-cinema",
													"cinema2"
												}
											},
											{
 												"description",
												"sets THX U2/S2/I/S Cinema/Cinema2"
											}
										}
									},
									{
 										"51",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"thx-musicmode",
													"thx-u2",
													"s2",
													"i",
													"s-music"
												}
											},
											{
 												"description",
												"sets THX MusicMode,THX U2/S2/I/S Music"
											}
										}
									},
									{
 										"52",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"thx-games",
													"thx-u2",
													"s2",
													"i",
													"s-games"
												}
											},
											{
 												"description",
												"sets THX Games Mode,THX U2/S2/I/S Games"
											}
										}
									},
									{
 										"80",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-movie"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Movie"
											}
										}
									},
									{
 										"81",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-music"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Music"
											}
										}
									},
									{
 										"82",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neo-6-cinema",
													"neo-x-cinema"
												}
											},
											{
 												"description",
												"sets Neo:6 Cinema/Neo:X Cinema"
											}
										}
									},
									{
 										"83",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neo-6-music",
													"neo-x-music"
												}
											},
											{
 												"description",
												"sets Neo:6 Music/Neo:X Music"
											}
										}
									},
									{
 										"84",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-thx-cinema"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Cinema"
											}
										}
									},
									{
 										"85",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neo-6",
													"neo-x-thx-cinema"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Cinema"
											}
										}
									},
									{
 										"86",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-game"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Game"
											}
										}
									},
									{
 										"87",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-surr"
											},
											{
 												"description",
												"sets Neural Surr"
											}
										}
									},
									{
 										"88",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neural-thx",
													"neural-surround"
												}
											},
											{
 												"description",
												"sets Neural THX/Neural Surround"
											}
										}
									},
									{
 										"89",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-thx-games"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Games"
											}
										}
									},
									{
 										"8A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neo-6",
													"neo-x-thx-games"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Games"
											}
										}
									},
									{
 										"8B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"plii",
													"pliix-thx-music"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Music"
											}
										}
									},
									{
 										"8C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"neo-6",
													"neo-x-thx-music"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Music"
											}
										}
									},
									{
 										"8D",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-thx-cinema"
											},
											{
 												"description",
												"sets Neural THX Cinema"
											}
										}
									},
									{
 										"8E",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-thx-music"
											},
											{
 												"description",
												"sets Neural THX Music"
											}
										}
									},
									{
 										"8F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-thx-games"
											},
											{
 												"description",
												"sets Neural THX Games"
											}
										}
									},
									{
 										"90",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pliiz-height"
											},
											{
 												"description",
												"sets PLIIz Height"
											}
										}
									},
									{
 										"91",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neo-6-cinema-dts-surround-sensation"
											},
											{
 												"description",
												"sets Neo:6 Cinema DTS Surround Sensation"
											}
										}
									},
									{
 										"92",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neo-6-music-dts-surround-sensation"
											},
											{
 												"description",
												"sets Neo:6 Music DTS Surround Sensation"
											}
										}
									},
									{
 										"93",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-digital-music"
											},
											{
 												"description",
												"sets Neural Digital Music"
											}
										}
									},
									{
 										"94",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pliiz-height-thx-cinema"
											},
											{
 												"description",
												"sets PLIIz Height + THX Cinema"
											}
										}
									},
									{
 										"95",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pliiz-height-thx-music"
											},
											{
 												"description",
												"sets PLIIz Height + THX Music"
											}
										}
									},
									{
 										"96",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pliiz-height-thx-games"
											},
											{
 												"description",
												"sets PLIIz Height + THX Games"
											}
										}
									},
									{
 										"97",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliiz-height-thx-u2",
													"s2-cinema"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Cinema"
											}
										}
									},
									{
 										"98",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliiz-height-thx-u2",
													"s2-music"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Music"
											}
										}
									},
									{
 										"99",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliiz-height-thx-u2",
													"s2-games"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Games"
											}
										}
									},
									{
 										"9A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neo-x-game"
											},
											{
 												"description",
												"sets Neo:X Game"
											}
										}
									},
									{
 										"A0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliix",
													"plii-movie-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Movie + Audyssey DSX"
											}
										}
									},
									{
 										"A1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliix",
													"plii-music-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Music + Audyssey DSX"
											}
										}
									},
									{
 										"A2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"pliix",
													"plii-game-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Game + Audyssey DSX"
											}
										}
									},
									{
 										"A3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neo-6-cinema-audyssey-dsx"
											},
											{
 												"description",
												"sets Neo:6 Cinema + Audyssey DSX"
											}
										}
									},
									{
 										"A4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neo-6-music-audyssey-dsx"
											},
											{
 												"description",
												"sets Neo:6 Music + Audyssey DSX"
											}
										}
									},
									{
 										"A5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-surround-audyssey-dsx"
											},
											{
 												"description",
												"sets Neural Surround + Audyssey DSX"
											}
										}
									},
									{
 										"A6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"neural-digital-music-audyssey-dsx"
											},
											{
 												"description",
												"sets Neural Digital Music + Audyssey DSX"
											}
										}
									},
									{
 										"A7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dolby-ex-audyssey-dsx"
											},
											{
 												"description",
												"sets Dolby EX + Audyssey DSX"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Down"
											}
										}
									},
									{
 										"MOVIE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"movie"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"MUSIC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"music"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"GAME",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"game"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Listening Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"late-night"
							},
							{
 								"description",
								"Late Night Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Late Night Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"low-dolbydigital",
													"on-dolby-truehd"
												}
											},
											{
 												"description",
												"sets Late Night Low@DolbyDigital,On@Dolby TrueHD"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"high-dolbydigital"
												}
											},
											{
 												"description",
												"sets Late Night High@DolbyDigital,(On@Dolby TrueHD)"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto-dolby-truehd"
											},
											{
 												"description",
												"sets Late Night Auto@Dolby TrueHD"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Late Night State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Late Night Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RAS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"cinema-filter"
							},
							{
 								"description",
								"Cinema Filter Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Cinema Filter Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Cinema Filter On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Cinema Filter State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Cinema Filter State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADY",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audyssey-2eq-multeq-multeq-xt"
							},
							{
 								"description",
								"Audyssey 2EQ/MultEQ/MultEQ XT"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"off"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"on",
													"movie"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT On/Movie"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"music"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT Music"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey 2EQ/MultEQ/MultEQ XT State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADQ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audyssey-dynamic-eq"
							},
							{
 								"description",
								"Audyssey Dynamic EQ"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey Dynamic EQ State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"audyssey-dynamic-volume"
							},
							{
 								"description",
								"Audyssey Dynamic Volume"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"light"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Light"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"medium"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Medium"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"heavy"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Heavy"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey Dynamic Volume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dolby-volume"
							},
							{
 								"description",
								"Dolby Volume"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Dolby Volume Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"low",
													"on"
												}
											},
											{
 												"description",
												"sets Dolby Volume Low/On"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mid"
											},
											{
 												"description",
												"sets Dolby Volume Mid"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"high"
											},
											{
 												"description",
												"sets Dolby Volume High"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Dolby Volume State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dolby Volume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MOT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"music-optimizer"
							},
							{
 								"description",
								"Music Optimizer"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Music Optimizer Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Music Optimizer On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Music Optimizer State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dolby Volume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command (Include Tuner Pack Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)\nput 0" +
    " in the first two digits of nnnnn at SR"
											}
										}
									},
									{
 										"DIRECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command (Include Tuner Pack Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset-memory"
							},
							{
 								"description",
								"Preset Memory Command (Include Tuner Pack Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"rds-information"
							},
							{
 								"description",
								"RDS Information Command (RDS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"00"
											},
											{
 												"description",
												"Display RT Information"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"01"
											},
											{
 												"description",
												"Display PTY Information"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"02"
											},
											{
 												"description",
												"Display TP Information"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"Display RDS Information Wrap-Around Change"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PTS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"pty-scan"
							},
							{
 								"description",
								"PTY Scan Command (RDS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-0-30"
											},
											{
 												"description",
												"sets PTY No “0 - 30” ( In hexadecimal representation)"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Finish PTY Scan"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TPS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tp-scan"
							},
							{
 								"description",
								"TP Scan Command (RDS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Start TP Scan (When Don’t Have Parameter)"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Finish TP Scan"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"xm-channel-name-info"
							},
							{
 								"description",
								"XM Channel Name Info (XM Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"XM Channel Name"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"xm-artist-name-info"
							},
							{
 								"description",
								"XM Artist Name Info (XM Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"XM Artist Name"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"xm-title-info"
							},
							{
 								"description",
								"XM Title Info (XM Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"XM Title"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"xm-channel-number"
							},
							{
 								"description",
								"XM Channel Number Command (XM Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"597"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"XM Channel Number  “000 - 255”"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets XM Channel Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets XM Channel Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Channel Number"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"xm-category"
							},
							{
 								"description",
								"XM Category Command (XM Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"XM Category Info"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets XM Category Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets XM Category Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Category"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-channel-name-info"
							},
							{
 								"description",
								"SIRIUS Channel Name Info (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"SIRIUS Channel Name"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-artist-name-info"
							},
							{
 								"description",
								"SIRIUS Artist Name Info (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"SIRIUS Artist Name"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"STI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-title-info"
							},
							{
 								"description",
								"SIRIUS Title Info (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"SIRIUS Title"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-channel-number"
							},
							{
 								"description",
								"SIRIUS Channel Number Command (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"597"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"SIRIUS Channel Number  “000 - 255”"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets SIRIUS Channel Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets SIRIUS Channel Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Channel Number"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-category"
							},
							{
 								"description",
								"SIRIUS Category Command (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"SIRIUS Category Info"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets SIRIUS Category Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets SIRIUS Category Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Category"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLK",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"sirius-parental-lock"
							},
							{
 								"description",
								"SIRIUS Parental Lock Command (SIRIUS Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Lock Password (4Digits)"
											}
										}
									},
									{
 										"INPUT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"input"
											},
											{
 												"description",
												"displays \"Please input the Lock password\""
											}
										}
									},
									{
 										"WRONG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"wrong"
											},
											{
 												"description",
												"displays \"The Lock password is wrong\""
											}
										}
									}
								}
							}
						}
					},
					{
 						"HAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-artist-name-info"
							},
							{
 								"description",
								"HD Radio Artist Name Info (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Artist Name (variable-length, 64 digits max)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-channel-name-info"
							},
							{
 								"description",
								"HD Radio Channel Name Info (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Channel Name (Station Name) (7 digits)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-title-info"
							},
							{
 								"description",
								"HD Radio Title Info (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Title (variable-length, 64 digits max)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-detail-info"
							},
							{
 								"description",
								"HD Radio Detail Info (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Title"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-channel-program"
							},
							{
 								"description",
								"HD Radio Channel Program Command (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"8"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"directly"
											},
											{
 												"description",
												"sets directly HD Radio Channel Program"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Program"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HBL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-blend-mode"
							},
							{
 								"description",
								"HD Radio Blend Mode Command (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Auto\""
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"analog"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Analog\""
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Blend Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HTS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-tuner-status"
							},
							{
 								"description",
								"HD Radio Tuner Status (HD Radio Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"mmnnoo",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mmnnoo"
											},
											{
 												"description",
												"HD Radio Tuner Status (3 bytes)\nmm -> \"00\" not HD, \"01\" HD\nnn -> current Program " +
    "\"01\"-\"08\"\noo -> receivable Program (8 bits are represented in hexadecimal notati" +
    "on. Each bit shows receivable or not.)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Tuner Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"network-usb"
							},
							{
 								"description",
								"Network/USB Operation Command (Network Model Only after TX-NR905)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*)"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*)"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY"
											}
										}
									},
									{
 										"DISPLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY"
											}
										}
									},
									{
 										"ALBUM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"album"
											},
											{
 												"description",
												"ALBUM KEY"
											}
										}
									},
									{
 										"ARTIST",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"artist"
											},
											{
 												"description",
												"ARTIST KEY"
											}
										}
									},
									{
 										"GENRE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"genre"
											},
											{
 												"description",
												"GENRE KEY"
											}
										}
									},
									{
 										"PLAYLIST",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"playlist"
											},
											{
 												"description",
												"PLAYLIST KEY"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY"
											}
										}
									},
									{
 										"SELECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0 KEY"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1 KEY"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2 KEY"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3 KEY"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4 KEY"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5 KEY"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6 KEY"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7 KEY"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8 KEY"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9 KEY"
											}
										}
									},
									{
 										"DELETE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"delete"
											},
											{
 												"description",
												"DELETE KEY"
											}
										}
									},
									{
 										"CAPS",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"caps"
											},
											{
 												"description",
												"CAPS KEY"
											}
										}
									},
									{
 										"LOCATION",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"location"
											},
											{
 												"description",
												"LOCATION KEY"
											}
										}
									},
									{
 										"LANGUAGE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"language"
											},
											{
 												"description",
												"LANGUAGE KEY"
											}
										}
									},
									{
 										"SETUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"setup"
											},
											{
 												"description",
												"SETUP KEY"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY"
											}
										}
									},
									{
 										"CHUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWN(for iRadio)"
											}
										}
									},
									{
 										"MENU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"MENU"
											}
										}
									},
									{
 										"TOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"top"
											},
											{
 												"description",
												"TOP MENU"
											}
										}
									},
									{
 										"MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mode"
											},
											{
 												"description",
												"MODE(for iPod) STD<->EXT"
											}
										}
									},
									{
 										"LIST",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"list"
											},
											{
 												"description",
												"LIST <-> PLAYBACK"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-artist-name-info"
							},
							{
 								"description",
								"NET/USB Artist Name Info"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"NET/USB Artist Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , fo" +
    "r Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NAL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-album-name-info"
							},
							{
 								"description",
								"NET/USB Album Name Info"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"NET/USB Album Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Album Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-title-name"
							},
							{
 								"description",
								"NET/USB Title Name"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"NET/USB Title Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-time-info"
							},
							{
 								"description",
								"NET/USB Time Info"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"mm:ss/mm:ss",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mm-ss-mm-ss"
											},
											{
 												"description",
												"NET/USB Time Info (Elapsed time/Track Time Max 99:59)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-track-info"
							},
							{
 								"description",
								"NET/USB Track Info"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"cccc/tttt",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"cccc-tttt"
											},
											{
 												"description",
												"NET/USB Track Info (Current Track/Toral Track Max 9999)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NST",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-play-status"
							},
							{
 								"description",
								"NET/USB Play Status"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"prs",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"prs"
											},
											{
 												"description",
												"NET/USB Play Status (3 letters)\np -> Play Status: \"S\": STOP, \"P\": Play, \"p\": Paus" +
    "e, \"F\": FF, \"R\": FR\nr -> Repeat Status: \"-\": Off, \"R\": All, \"F\": Folder, \"1\": Re" +
    "peat 1,\ns -> Shuffle Status: \"-\": Off, \"S\": All , \"A\": Album, \"F\": Folder"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"SET",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"set"
											},
											{
 												"description",
												"preset memory current station"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NLS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-list-info"
							},
							{
 								"description",
								"NET/USB List Info"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"tlpnnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												@"NET/USB List Info
t ->Information Type (A : ASCII letter, C : Cursor Info, U : Unicode letter)
when t = A,
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 ASCII letters max)
    when AVR is not displayed NET/USB List(Ketboard,Menu,Popup…), ""nnnnnnnnn"" is ""See TV"".
  p ->Property (- : no)
when t = C,
  l ->Cursor Position (0-9 : 1st to 10th Line, - : No Cursor)
  p ->Update Type (P : Page Infomation Update ( Page Clear or Disable List Info) , C : Cursor Position Update)
when t = U, (for Network Control Only)
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 Unicode letters [UTF-8 encoded] max)
    when AVR is not displayed NET/USB List(Ketboard,Menu,Popup…), ""nnnnnnnnn"" is ""See TV"".
  p ->Property (- : no)"
											}
										}
									},
									{
 										"ti",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ti"
											},
											{
 												"description",
												"select the listed item (from Network Control Only)\n t -> Index Type (L : Line, I " +
    ": Index)\nwhen t = L,\n  i -> Line number (0-9 : 1st to 10th Line [1 digit] )\nwhen" +
    " t = I,\n  iiiii -> Index number (00001-99999 : 1st to 99999th Item [5 digits] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NJA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-usb-jacket-art"
							},
							{
 								"description",
								"NET/USB Jacket Art (When Jacket Art is available and Output for Network Control O" +
    "nly)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"tp{xx}{xx}{xx}{xx}{xx}{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tp-xx-xx-xx-xx-xx-xx"
											},
											{
 												"description",
												"NET/USB Jacket Art/Album Art Data\nt-> Image type 0:BMP,1:JPEG\np-> Packet flag 0:S" +
    "tart, 1:Next, 2:End\nxxxxxxxxxxxxxx -> Jacket/Album Art Data (valiable length, 10" +
    "24 ASCII HEX letters max)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NSV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-service"
							},
							{
 								"description",
								"NET Service(for Network Control Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"ssiaaaa…aaaabbbb…bbbb",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												@"select Network Service directly
ss -> Network Serveice
 00:Media Server (DLNA)
 01:Favorite
 02:vTuner
 03:SIRIUS
 04:Pandora
 05:Rhapsody
 06:Last.fm
 07:Napster
 08:Slacker
 09:Mediafly
 0A:Spotify
 0B:AUPEO!
 0C:Radiko
 0D:e-onkyo

i-> Acount Info
 0: No
 1: Yes
""aaaa...aaaa"": User Name ( 128 Unicode letters [UTF-8 encoded] max )
""bbbb...bbbb"": Password ( 128 Unicode letters [UTF-8 encoded] max )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NKY",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-keyboard"
							},
							{
 								"description",
								"NET Keyboard(for Network Control Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"ll",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ll"
											},
											{
 												"description",
												@"waiting Keyboard Input
ll -> category
 00: Off ( Exit Keyboard Input )
 01: User Name
 02: Password
 03: Artist Name
 04: Album Name
 05: Song Name
 06: Station Name
 07: Tag Name
 08: Artist or Song
 09: Episode Name
 0A: Pin Code (some digit Number [0-9])
 0B: User Name (available ISO 8859-1 character set)
 0C: Password (available ISO 8859-1 character set)"
											}
										}
									},
									{
 										"nnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"set Keyboard Input letter\n\"nnnnnnnn\" is variable-length, 128 Unicode letters [UTF" +
    "-8 encoded] max"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPU",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-popup-message"
							},
							{
 								"description",
								"NET Popup Message(for Network Control Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"xaaa…aaaybbb…bbb",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												@"x -> Popup Display Type
 'T': Popup text is top
 'B': Popup text is bottom
 'L': Popup text is list format

aaa...aaa -> Popup Title, Massage
 when x = 'T' or 'B'
    Top Title [0x00] Popup Title [0x00] Popup Message [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )

 when x = 'L'
    Top Title [0x00] Item Title 1 [0x00] Item Parameter 1 [0x00] ... [0x00] Item Title 6 [0x00] Item Parameter 6 [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )

y -> Cursor Position on button
 '0' : Button is not Displayed
 '1' : Cursor is on the button 1
 '2' : Cursor is on the button 2

bbb...bbb -> Text of Button
    Text of Button 1 [0x00] Text of Button 2 [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-mode-change"
							},
							{
 								"description",
								"iPod Mode Change (with USB Connection Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"STD",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"std"
											},
											{
 												"description",
												"Standerd Mode"
											}
										}
									},
									{
 										"EXT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ext"
											},
											{
 												"description",
												"Extend Mode(If available)"
											}
										}
									},
									{
 										"VDC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"vdc"
											},
											{
 												"description",
												"Video Contents in Extended Mode"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CCD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"cd-player"
							},
							{
 								"description",
								"CD Player Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"POWER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"POWER ON/OFF"
											}
										}
									},
									{
 										"TRACK",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"track"
											},
											{
 												"description",
												"TRACK+"
											}
										}
									},
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"MEMORY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY"
											}
										}
									},
									{
 										"CLEAR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"CLEAR"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM"
											}
										}
									},
									{
 										"DISP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disp"
											},
											{
 												"description",
												"DISPLAY"
											}
										}
									},
									{
 										"D.MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"d-mode"
											},
											{
 												"description",
												"D.MODE"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									},
									{
 										"OP/CL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"op-cl"
											},
											{
 												"description",
												"OPEN/CLOSE"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1.0"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2.0"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3.0"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4.0"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5.0"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6.0"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7.0"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8.0"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9.0"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0.0"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10"
											},
											{
 												"description",
												"10.0"
											}
										}
									},
									{
 										"+10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10"
											},
											{
 												"description",
												"+10"
											}
										}
									},
									{
 										"D.SKIP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"d-skip"
											},
											{
 												"description",
												"DISC +"
											}
										}
									},
									{
 										"DISC.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc-f"
											},
											{
 												"description",
												"DISC +"
											}
										}
									},
									{
 										"DISC.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc-r"
											},
											{
 												"description",
												"DISC -"
											}
										}
									},
									{
 										"DISC1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc1"
											},
											{
 												"description",
												"DISC1"
											}
										}
									},
									{
 										"DISC2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc2"
											},
											{
 												"description",
												"DISC2"
											}
										}
									},
									{
 										"DISC3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc3"
											},
											{
 												"description",
												"DISC3"
											}
										}
									},
									{
 										"DISC4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc4"
											},
											{
 												"description",
												"DISC4"
											}
										}
									},
									{
 										"DISC5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc5"
											},
											{
 												"description",
												"DISC5"
											}
										}
									},
									{
 										"DISC6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc6"
											},
											{
 												"description",
												"DISC6"
											}
										}
									},
									{
 										"STBY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stby"
											},
											{
 												"description",
												"STANDBY"
											}
										}
									},
									{
 										"PON",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pon"
											},
											{
 												"description",
												"POWER ON"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CT1",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tape1-a"
							},
							{
 								"description",
								"TAPE1(A) Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play-f"
											},
											{
 												"description",
												"PLAY >"
											}
										}
									},
									{
 										"PLAY.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play-r"
											},
											{
 												"description",
												"PLAY <"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"RC/PAU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rc-pau"
											},
											{
 												"description",
												"REC/PAUSE"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CT2",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tape2-b"
							},
							{
 								"description",
								"TAPE2(B) Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play-f"
											},
											{
 												"description",
												"PLAY >"
											}
										}
									},
									{
 										"PLAY.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play-r"
											},
											{
 												"description",
												"PLAY <"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"RC/PAU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rc-pau"
											},
											{
 												"description",
												"REC/PAUSE"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									},
									{
 										"OP/CL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"op-cl"
											},
											{
 												"description",
												"OPEN/CLOSE"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"REC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rec"
											},
											{
 												"description",
												"REC"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CEQ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"graphics-equalizer"
							},
							{
 								"description",
								"Graphics Equalizer Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"POWER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"POWER ON/OFF"
											}
										}
									},
									{
 										"PRESET",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"preset"
											},
											{
 												"description",
												"PRESET"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CDT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dat-recorder"
							},
							{
 								"description",
								"DAT Recorder Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"RC/PAU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rc-pau"
											},
											{
 												"description",
												"REC/PAUSE"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CDV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dvd-player"
							},
							{
 								"description",
								"DVD Player Operation Command (via RIHD only after TX-NR509)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"POWER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"POWER ON/OFF"
											}
										}
									},
									{
 										"PWRON",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pwron"
											},
											{
 												"description",
												"POWER ON"
											}
										}
									},
									{
 										"PWROFF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pwroff"
											},
											{
 												"description",
												"POWER OFF"
											}
										}
									},
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"LASTPLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"lastplay"
											},
											{
 												"description",
												"LAST PLAY"
											}
										}
									},
									{
 										"SUBTON/OFF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"subton-off"
											},
											{
 												"description",
												"SUBTITLE ON/OFF"
											}
										}
									},
									{
 										"SUBTITLE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"subtitle"
											},
											{
 												"description",
												"SUBTITLE"
											}
										}
									},
									{
 										"SETUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"setup"
											},
											{
 												"description",
												"SETUP"
											}
										}
									},
									{
 										"TOPMENU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"topmenu"
											},
											{
 												"description",
												"TOPMENU"
											}
										}
									},
									{
 										"MENU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"MENU"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"ENTER"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN"
											}
										}
									},
									{
 										"DISC.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc-f"
											},
											{
 												"description",
												"DISC +"
											}
										}
									},
									{
 										"DISC.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc-r"
											},
											{
 												"description",
												"DISC -"
											}
										}
									},
									{
 										"AUDIO",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"audio"
											},
											{
 												"description",
												"AUDIO"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM"
											}
										}
									},
									{
 										"OP/CL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"op-cl"
											},
											{
 												"description",
												"OPEN/CLOSE"
											}
										}
									},
									{
 										"ANGLE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"angle"
											},
											{
 												"description",
												"ANGLE"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1.0"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2.0"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3.0"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4.0"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5.0"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6.0"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7.0"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8.0"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9.0"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10"
											},
											{
 												"description",
												"10.0"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0.0"
											}
										}
									},
									{
 										"SEARCH",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"search"
											},
											{
 												"description",
												"SEARCH"
											}
										}
									},
									{
 										"DISP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disp"
											},
											{
 												"description",
												"DISPLAY"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"MEMORY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY"
											}
										}
									},
									{
 										"CLEAR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"CLEAR"
											}
										}
									},
									{
 										"ABR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"abr"
											},
											{
 												"description",
												"A-B REPEAT"
											}
										}
									},
									{
 										"STEP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"step-f"
											},
											{
 												"description",
												"STEP"
											}
										}
									},
									{
 										"STEP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"step-r"
											},
											{
 												"description",
												"STEP BACK"
											}
										}
									},
									{
 										"SLOW.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"slow-f"
											},
											{
 												"description",
												"SLOW"
											}
										}
									},
									{
 										"SLOW.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"slow-r"
											},
											{
 												"description",
												"SLOW BACK"
											}
										}
									},
									{
 										"ZOOMTG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"zoomtg"
											},
											{
 												"description",
												"ZOOM"
											}
										}
									},
									{
 										"ZOOMUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"zoomup"
											},
											{
 												"description",
												"ZOOM UP"
											}
										}
									},
									{
 										"ZOOMDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"zoomdn"
											},
											{
 												"description",
												"ZOOM DOWN"
											}
										}
									},
									{
 										"PROGRE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"progre"
											},
											{
 												"description",
												"PROGRESSIVE"
											}
										}
									},
									{
 										"VDOFF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"vdoff"
											},
											{
 												"description",
												"VIDEO ON/OFF"
											}
										}
									},
									{
 										"CONMEM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"conmem"
											},
											{
 												"description",
												"CONDITION MEMORY"
											}
										}
									},
									{
 										"FUNMEM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"funmem"
											},
											{
 												"description",
												"FUNCTION MEMORY"
											}
										}
									},
									{
 										"DISC1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc1"
											},
											{
 												"description",
												"DISC1"
											}
										}
									},
									{
 										"DISC2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc2"
											},
											{
 												"description",
												"DISC2"
											}
										}
									},
									{
 										"DISC3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc3"
											},
											{
 												"description",
												"DISC3"
											}
										}
									},
									{
 										"DISC4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc4"
											},
											{
 												"description",
												"DISC4"
											}
										}
									},
									{
 										"DISC5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc5"
											},
											{
 												"description",
												"DISC5"
											}
										}
									},
									{
 										"DISC6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disc6"
											},
											{
 												"description",
												"DISC6"
											}
										}
									},
									{
 										"FOLDUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"foldup"
											},
											{
 												"description",
												"FOLDER UP"
											}
										}
									},
									{
 										"FOLDDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"folddn"
											},
											{
 												"description",
												"FOLDER DOWN"
											}
										}
									},
									{
 										"P.MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"p-mode"
											},
											{
 												"description",
												"PLAY MODE"
											}
										}
									},
									{
 										"ASCTG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"asctg"
											},
											{
 												"description",
												"ASPECT(Toggle)"
											}
										}
									},
									{
 										"CDPCD",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"cdpcd"
											},
											{
 												"description",
												"CD CHAIN REPEAT"
											}
										}
									},
									{
 										"MSPUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mspup"
											},
											{
 												"description",
												"MULTI SPEED UP"
											}
										}
									},
									{
 										"MSPDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mspdn"
											},
											{
 												"description",
												"MULTI SPEED DOWN"
											}
										}
									},
									{
 										"PCT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pct"
											},
											{
 												"description",
												"PICTURE CONTROL"
											}
										}
									},
									{
 										"RSCTG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rsctg"
											},
											{
 												"description",
												"RESOLUTION(Toggle)"
											}
										}
									},
									{
 										"INIT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"init"
											},
											{
 												"description",
												"Return to Factory Settings"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"md-recorder"
							},
							{
 								"description",
								"MD Recorder Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"POWER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"POWER ON/OFF"
											}
										}
									},
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									},
									{
 										"P.MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"p-mode"
											},
											{
 												"description",
												"PLAY MODE"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"REC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rec"
											},
											{
 												"description",
												"REC"
											}
										}
									},
									{
 										"MEMORY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY"
											}
										}
									},
									{
 										"DISP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disp"
											},
											{
 												"description",
												"DISPLAY"
											}
										}
									},
									{
 										"SCROLL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"scroll"
											},
											{
 												"description",
												"SCROLL"
											}
										}
									},
									{
 										"M.SCAN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"m-scan"
											},
											{
 												"description",
												"MUSIC SCAN"
											}
										}
									},
									{
 										"CLEAR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"CLEAR"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"ENTER"
											}
										}
									},
									{
 										"EJECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"eject"
											},
											{
 												"description",
												"EJECT"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1.0"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2.0"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3.0"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4.0"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5.0"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6.0"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7.0"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8.0"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9.0"
											}
										}
									},
									{
 										"10/0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10-0"
											},
											{
 												"description",
												"10/0"
											}
										}
									},
									{
 										"nn/nnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"--/---"
											}
										}
									},
									{
 										"NAME",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"name"
											},
											{
 												"description",
												"NAME"
											}
										}
									},
									{
 										"GROUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"group"
											},
											{
 												"description",
												"GROUP"
											}
										}
									},
									{
 										"STBY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stby"
											},
											{
 												"description",
												"STANDBY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CCR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"cd-r-recorder"
							},
							{
 								"description",
								"CD-R Recorder Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"POWER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"POWER ON/OFF"
											}
										}
									},
									{
 										"P.MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"p-mode"
											},
											{
 												"description",
												"PLAY MODE"
											}
										}
									},
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"REC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rec"
											},
											{
 												"description",
												"REC"
											}
										}
									},
									{
 										"CLEAR",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"CLEAR"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1.0"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2.0"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3.0"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4.0"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5.0"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6.0"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7.0"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8.0"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9.0"
											}
										}
									},
									{
 										"10/0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10-0"
											},
											{
 												"description",
												"10/0"
											}
										}
									},
									{
 										"nn/nnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"--/---"
											}
										}
									},
									{
 										"SCROLL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"scroll"
											},
											{
 												"description",
												"SCROLL"
											}
										}
									},
									{
 										"OP/CL",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"op-cl"
											},
											{
 												"description",
												"OPEN/CLOSE"
											}
										}
									},
									{
 										"DISP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disp"
											},
											{
 												"description",
												"DISPLAY"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM"
											}
										}
									},
									{
 										"MEMORY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW"
											}
										}
									},
									{
 										"STBY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stby"
											},
											{
 												"description",
												"STANDBY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CPT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"universal-port"
							},
							{
 								"description",
								"Universal PORT Operation Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"SETUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"setup"
											},
											{
 												"description",
												"SETUP"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP/Tuning Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN/Tuning Down"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT/Multicast Down"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT/Multicast Up"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"ENTER"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN"
											}
										}
									},
									{
 										"DISP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"disp"
											},
											{
 												"description",
												"DISPLAY"
											}
										}
									},
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY/BAND"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF >>"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW <<"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"SHUFFLE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"shuffle"
											},
											{
 												"description",
												"SHUFFLE"
											}
										}
									},
									{
 										"PRSUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"prsup"
											},
											{
 												"description",
												"PRESET UP"
											}
										}
									},
									{
 										"PRSDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"prsdn"
											},
											{
 												"description",
												"PRESET DOWN"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0.0"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1.0"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2.0"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3.0"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4.0"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5.0"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6.0"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7.0"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8.0"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9.0"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"10"
											},
											{
 												"description",
												"10/+10/Direct Tuning"
											}
										}
									},
									{
 										"MODE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mode"
											},
											{
 												"description",
												"MODE"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-artist-name-info"
							},
							{
 								"description",
								"iPod Artist Name Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"iPod Artist Name (variable-length, 64 letters max ASCII letter only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IAL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-album-name-info"
							},
							{
 								"description",
								"iPod Album Name Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"iPod Album Name (variable-length, 64 letters max ASCII letter only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Album Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ITI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-title-name"
							},
							{
 								"description",
								"iPod Title Name (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"iPod Title Name (variable-length, 64 letters max ASCII letter only)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Title Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ITM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-time-info"
							},
							{
 								"description",
								"iPod Time Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"mm:ss/mm:ss",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mm-ss-mm-ss"
											},
											{
 												"description",
												"iPod Time Info (Elapsed time/Track Time Max 99:59)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ITR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-track-info"
							},
							{
 								"description",
								"iPod Track Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"cccc/tttt",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"cccc-tttt"
											},
											{
 												"description",
												"iPod Track Info (Current Track/Toral Track Max 9999)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IST",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-play-status"
							},
							{
 								"description",
								"iPod Play Status (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"prs",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"prs"
											},
											{
 												"description",
												"iPod Play Status (3 letters)\np -> Play Status \"S\" STOP, \"P\" Play, \"p\" Pause, \"F\" " +
    "FF, \"R\" FR\nr -> Repeat Status \"-\" no Repeat, \"R\" All Repeat, \"1\" Repeat 1,\ns -> " +
    "Shuffle Status \"-\" no Shuffle, \"S\" Shuffle, \"A\" Album Shuffle"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the iPod Play Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ILS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-list-info"
							},
							{
 								"description",
								"iPod List Info (Universal Port Dock Extend Mode Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"tlpnnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												@"iPod List Info
t ->Information Type (A : ASCII letter, C : Cursor Info)
when t = A,
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 letters max ASCII letter only)
  p ->Property (- : no)
when t = C,
  l ->Cursor Position (0-9 : 1st to 10th Line, - : No Cursor)
  p ->Update Type (P : Page Infomation Update ( Page Clear or Disable List Info) , C : Cursor Position Update)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"ipod-mode-change"
							},
							{
 								"description",
								"iPod Mode Change (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"STD",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"std"
											},
											{
 												"description",
												"Standerd Mode"
											}
										}
									},
									{
 										"EXT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ext"
											},
											{
 												"description",
												"Extend Mode(If available)"
											}
										}
									},
									{
 										"VDC",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"vdc"
											},
											{
 												"description",
												"Video Contents in Extended Mode"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dab-preset"
							},
							{
 								"description",
								"DAB Preset Command (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"UPM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset-memory"
							},
							{
 								"description",
								"Preset Memory Command (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Memory Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHP",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-channel-program"
							},
							{
 								"description",
								"HD Radio Channel Program Command (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"8"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"directly"
											},
											{
 												"description",
												"sets directly HD Radio Channel Program"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Program"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-blend-mode"
							},
							{
 								"description",
								"HD Radio Blend Mode Command (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Auto\""
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"analog"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Analog\""
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Blend Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-artist-name-info"
							},
							{
 								"description",
								"HD Radio Artist Name Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Artist Name (variable-length, 64 letters max)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-channel-name-info"
							},
							{
 								"description",
								"HD Radio Channel Name Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Channel Name (Station Name) (7lettters)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-title-info"
							},
							{
 								"description",
								"HD Radio Title Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Title (variable-length, 64 letters max)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-detail-info"
							},
							{
 								"description",
								"HD Radio Detail Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"HD Radio Title"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UHS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"hd-radio-tuner-status"
							},
							{
 								"description",
								"HD Radio Tuner Status (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"mmnnoo",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mmnnoo"
											},
											{
 												"description",
												"HD Radio Tuner Status (3 bytes)\nmm -> \"00\" not HD, \"01\" HD\nnn -> current Program " +
    "\"01\"-\"08\"\noo -> receivable Program (8 bits are represented in hexadecimal notati" +
    "on. Each bit shows receivable or not.)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Tuner Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dab-sation-name"
							},
							{
 								"description",
								"DAB Sation Name (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Sation Name (9 letters)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UDD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"dab-display-info"
							},
							{
 								"description",
								"DAB Display Info (Universal Port Dock Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PT:nnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"DAB Program Type (8 letters)"
											}
										}
									},
									{
 										"AT:mmmkbps/nnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"DAB Bitrate & Audio Type (m:Bitrate xxxkbps,n:Audio Type Stereo/Mono)"
											}
										}
									},
									{
 										"MN:nnnnnnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"DAB Multiplex Name (9 letters)"
											}
										}
									},
									{
 										"MF:mmm/nnnn.nnMHz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"DAB Multiplex Band ID(mmm) & Freq(nnnn.nnMHz) Info"
											}
										}
									},
									{
 										"PT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pt"
											},
											{
 												"description",
												"gets & display DAB Program Info"
											}
										}
									},
									{
 										"AT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"at"
											},
											{
 												"description",
												"gets & display DAB Bitrate & Audio Type"
											}
										}
									},
									{
 										"MN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mn"
											},
											{
 												"description",
												"gets & display DAB Multicast Name"
											}
										}
									},
									{
 										"MF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mf"
											},
											{
 												"description",
												"gets & display DAB Multicast Band & Freq Info"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"gets & dispaly DAB Infomation Wrap-Around Up"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone2",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"ZPW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone2 Power Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone2 Standby"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone2 On"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone2 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZMT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone2 Muting Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone2 Muting Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone2 Muting On"
											}
										}
									},
									{
 										"TG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone2 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone2 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone2 Volume Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"100"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"0",
											"80"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone"
							},
							{
 								"description",
								"Zone2 Tone Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-xx-is-a-00-a-10-0-10-2-step"
											},
											{
 												"description",
												"sets Zone2 Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-xx-is-a-00-a-10-0-10-2-step"
											},
											{
 												"description",
												"sets Zone2 Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Bass Up (2 Step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Bass Down (2 Step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Treble Up (2 Step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Treble Down (2 Step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone2 Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZBL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"balance"
							},
							{
 								"description",
								"Zone2 Balance Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xx-is-a-00-a-l-10-0-r-10-2-step"
											},
											{
 												"description",
												"sets Zone2 Balance (xx is \"-A\"...\"00\"...\"+A\"[L+10...0...R+10 2 step]"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Balance Up (to R 2 Step)"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Balance Down (to L 2 Step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone2 Balance"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE2 Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video1",
													"vcr",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video3",
													"game",
													"tv",
													"game"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video5",
													"aux2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden1"
											},
											{
 												"description",
												"sets Hidden1"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden2"
											},
											{
 												"description",
												"sets Hidden2"
											}
										}
									},
									{
 										"09",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden3"
											},
											{
 												"description",
												"sets Hidden3"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"dvd",
													"bd",
													"dvd"
												}
											},
											{
 												"description",
												"sets DVD, BD/DVD"
											}
										}
									},
									{
 										"20",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"cd",
													"tv",
													"cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"40",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"7F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets OFF"
											}
										}
									},
									{
 										"80",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / XM nnnnn ch)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)"
											}
										}
									},
									{
 										"DIRECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAYz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"CHUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWN(for iRadio)"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DISPLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LMZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"listening-mode"
							},
							{
 								"description",
								"Listening Mode Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stereo"
											},
											{
 												"description",
												"sets STEREO"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"sets DIRECT"
											}
										}
									},
									{
 										"0F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mono"
											},
											{
 												"description",
												"sets MONO"
											}
										}
									},
									{
 										"12",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multiplex"
											},
											{
 												"description",
												"sets MULTIPLEX"
											}
										}
									},
									{
 										"87",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dvs"
											},
											{
 												"description",
												"sets DVS(Pl2)"
											}
										}
									},
									{
 										"88",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dvs"
											},
											{
 												"description",
												"sets DVS(NEO6)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LTZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"late-night"
							},
							{
 								"description",
								"Late Night Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Late Night Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"low"
											},
											{
 												"description",
												"sets Late Night Low"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"high"
											},
											{
 												"description",
												"sets Late Night High"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Late Night State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Late Night Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RAZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"re-eq-academy-filter"
							},
							{
 								"description",
								"Re-EQ/Academy Filter Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"both-off"
											},
											{
 												"description",
												"sets Both Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Re-EQ On"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Academy On"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Re-EQ/Academy State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Re-EQ/Academy State"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone3",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PW3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone3 Power Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone3 Standby"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone3 On"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone3 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MT3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone3 Muting Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone3 Muting Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone3 Muting On"
											}
										}
									},
									{
 										"TG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone3 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone3 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone3 Volume Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"100"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"0",
											"80"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TN3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tone"
							},
							{
 								"description",
								"Zone3 Tone Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"B{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Zone3 Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step])"
											}
										}
									},
									{
 										"T{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Zone3 Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step])"
											}
										}
									},
									{
 										"BUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Bass Up (2 Step)"
											}
										}
									},
									{
 										"BDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Bass Down (2 Step)"
											}
										}
									},
									{
 										"TUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Treble Up (2 Step)"
											}
										}
									},
									{
 										"TDOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Treble Down (2 Step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone3 Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"BL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"balance"
							},
							{
 								"description",
								"Zone3 Balance Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"{xx}",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xx"
											},
											{
 												"description",
												"Zone3 Balance (xx is \"-A\"...\"00\"...\"+A\"[L+10...0...R+10 2 step])"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Balance Up (to R 2 Step)"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Balance Down (to L 2 Step)"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone3 Balance"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE3 Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video1",
													"vcr",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video3",
													"game",
													"tv",
													"game"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video5",
													"aux2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden1"
											},
											{
 												"description",
												"sets Hidden1"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden2"
											},
											{
 												"description",
												"sets Hidden2"
											}
										}
									},
									{
 										"09",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden3"
											},
											{
 												"description",
												"sets Hidden3"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dvd"
											},
											{
 												"description",
												"sets DVD"
											}
										}
									},
									{
 										"20",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"cd",
													"tv",
													"cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"40",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"80",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TU3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)"
											}
										}
									},
									{
 										"DIRECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PR3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAYz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NT3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"CHUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWNP(for iRadio)"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DISPLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NP3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone4",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PW4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone4 Power Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone4 Standby"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone4 On"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone4 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MT4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone4 Muting Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone4 Muting Off"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone4 Muting On"
											}
										}
									},
									{
 										"TG",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone4 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone4 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VL4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone4 Volume Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"0",
											"100"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"0",
											"80"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SL4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE4 Selector Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"00",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video1",
													"vcr",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR"
											}
										}
									},
									{
 										"01",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video3",
													"game",
													"tv",
													"game"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME"
											}
										}
									},
									{
 										"03",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"video5",
													"aux2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2"
											}
										}
									},
									{
 										"05",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video6"
											},
											{
 												"description",
												"sets VIDEO6"
											}
										}
									},
									{
 										"06",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden1"
											},
											{
 												"description",
												"sets Hidden1"
											}
										}
									},
									{
 										"08",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden2"
											},
											{
 												"description",
												"sets Hidden2"
											}
										}
									},
									{
 										"09",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"hidden3"
											},
											{
 												"description",
												"sets Hidden3"
											}
										}
									},
									{
 										"10",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"dvd"
											},
											{
 												"description",
												"sets DVD"
											}
										}
									},
									{
 										"20",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"tape-1",
													"tv",
													"tape"
												}
											},
											{
 												"description",
												"sets TAPE(1), TV/TAPE"
											}
										}
									},
									{
 										"21",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"cd",
													"tv",
													"cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												new object[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"40",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"80",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TU4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"nnnnn",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"DIRECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PR4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new object[]
										{
											"1",
											"30"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAYz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NT4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DISPLAY",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NP4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										new object[]
										{
											"1",
											"40"
										},
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"dock",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"CDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"name",
								"command-for-docking-station-via-ri"
							},
							{
 								"description",
								"Command for Docking Station via RI"
							},
							{
 								"values",
								new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
								{
									{
 										"PWRON",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Dock On"
											}
										}
									},
									{
 										"PWROFF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Dock Standby"
											}
										}
									},
									{
 										"PLY/RES",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ply-res"
											},
											{
 												"description",
												"PLAY/RESUME Key"
											}
										}
									},
									{
 										"STOP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP Key"
											}
										}
									},
									{
 										"SKIP.F",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-f"
											},
											{
 												"description",
												"TRACK UP Key"
											}
										}
									},
									{
 										"SKIP.R",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"skip-r"
											},
											{
 												"description",
												"TRACK DOWN Key"
											}
										}
									},
									{
 										"PAUSE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE Key"
											}
										}
									},
									{
 										"PLY/PAU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ply-pau"
											},
											{
 												"description",
												"PLAY/PAUSE Key"
											}
										}
									},
									{
 										"FF",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF Key"
											}
										}
									},
									{
 										"REW",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"FR Key"
											}
										}
									},
									{
 										"ALBUM+",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"album"
											},
											{
 												"description",
												"ALBUM UP Key"
											}
										}
									},
									{
 										"ALBUM-",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"album"
											},
											{
 												"description",
												"ALBUM DONW Key"
											}
										}
									},
									{
 										"PLIST+",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"plist"
											},
											{
 												"description",
												"PLAYLIST UP Key"
											}
										}
									},
									{
 										"PLIST-",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"plist"
											},
											{
 												"description",
												"PLAYLIST DOWN Key"
											}
										}
									},
									{
 										"CHAPT+",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chapt"
											},
											{
 												"description",
												"CHAPTER UP Key"
											}
										}
									},
									{
 										"CHAPT-",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"chapt"
											},
											{
 												"description",
												"CHAPTER DOWN Key"
											}
										}
									},
									{
 										"RANDOM",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"SHUFFLE Key"
											}
										}
									},
									{
 										"REPEAT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT Key"
											}
										}
									},
									{
 										"MUTE",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"mute"
											},
											{
 												"description",
												"MUTE Key"
											}
										}
									},
									{
 										"BLIGHT",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"blight"
											},
											{
 												"description",
												"BACKLIGHT Key"
											}
										}
									},
									{
 										"MENU",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"MENU Key"
											}
										}
									},
									{
 										"ENTER",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"SELECT Key"
											}
										}
									},
									{
 										"UP",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"CUSOR UP Key"
											}
										}
									},
									{
 										"DOWN",
										new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"CURSOR DOWN Key"
											}
										}
									}
								}
							}
						}
					}
				}
			}
		};

		public static readonly OrderedDictionary ZoneMappings = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
		{
			{
 				"",
				"main"
			}
		};

		public static readonly OrderedDictionary CommandMappings = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
		{
			{
 				"main",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"system-power",
						"PWR"
					},
					{
 						"audio-muting",
						"AMT"
					},
					{
 						"speaker-a",
						"SPA"
					},
					{
 						"speaker-b",
						"SPB"
					},
					{
 						"speaker-layout",
						"SPL"
					},
					{
 						"master-volume",
						"MVL"
					},
					{
 						"tone-front",
						"TFR"
					},
					{
 						"tone-front-wide",
						"TFW"
					},
					{
 						"tone-front-high",
						"TFH"
					},
					{
 						"tone-center",
						"TCT"
					},
					{
 						"tone-surround",
						"TSR"
					},
					{
 						"tone-surround-back",
						"TSB"
					},
					{
 						"tone-subwoofer",
						"TSW"
					},
					{
 						"sleep-set",
						"SLP"
					},
					{
 						"speaker-level-calibration",
						"SLC"
					},
					{
 						"subwoofer-temporary-level",
						"SWL"
					},
					{
 						"center-temporary-level",
						"CTL"
					},
					{
 						"display-mode",
						"DIF"
					},
					{
 						"dimmer-level",
						"DIM"
					},
					{
 						"setup",
						"OSD"
					},
					{
 						"memory-setup",
						"MEM"
					},
					{
 						"audio-infomation",
						"IFA"
					},
					{
 						"video-infomation",
						"IFV"
					},
					{
 						"input-selector",
						"SLI"
					},
					{
 						"recout-selector",
						"SLR"
					},
					{
 						"audio-selector",
						"SLA"
					},
					{
 						"12v-trigger-a",
						"TGA"
					},
					{
 						"12v-trigger-b",
						"TGB"
					},
					{
 						"12v-trigger-c",
						"TGC"
					},
					{
 						"video-output-selector",
						"VOS"
					},
					{
 						"hdmi-output-selector",
						"HDO"
					},
					{
 						"hdmi-audio-out",
						"HAO"
					},
					{
 						"monitor-out-resolution",
						"RES"
					},
					{
 						"isf-mode",
						"ISF"
					},
					{
 						"video-wide-mode",
						"VWM"
					},
					{
 						"video-picture-mode",
						"VPM"
					},
					{
 						"listening-mode",
						"LMD"
					},
					{
 						"late-night",
						"LTN"
					},
					{
 						"cinema-filter",
						"RAS"
					},
					{
 						"audyssey-2eq-multeq-multeq-xt",
						"ADY"
					},
					{
 						"audyssey-dynamic-eq",
						"ADQ"
					},
					{
 						"audyssey-dynamic-volume",
						"ADV"
					},
					{
 						"dolby-volume",
						"DVL"
					},
					{
 						"music-optimizer",
						"MOT"
					},
					{
 						"tuning",
						"UTN"
					},
					{
 						"preset",
						"PRS"
					},
					{
 						"preset-memory",
						"UPM"
					},
					{
 						"rds-information",
						"RDS"
					},
					{
 						"pty-scan",
						"PTS"
					},
					{
 						"tp-scan",
						"TPS"
					},
					{
 						"xm-channel-name-info",
						"XCN"
					},
					{
 						"xm-artist-name-info",
						"XAT"
					},
					{
 						"xm-title-info",
						"XTI"
					},
					{
 						"xm-channel-number",
						"XCH"
					},
					{
 						"xm-category",
						"XCT"
					},
					{
 						"sirius-channel-name-info",
						"SCN"
					},
					{
 						"sirius-artist-name-info",
						"SAT"
					},
					{
 						"sirius-title-info",
						"STI"
					},
					{
 						"sirius-channel-number",
						"SCH"
					},
					{
 						"sirius-category",
						"SCT"
					},
					{
 						"sirius-parental-lock",
						"SLK"
					},
					{
 						"hd-radio-artist-name-info",
						"UHA"
					},
					{
 						"hd-radio-channel-name-info",
						"UHC"
					},
					{
 						"hd-radio-title-info",
						"UHT"
					},
					{
 						"hd-radio-detail-info",
						"UHD"
					},
					{
 						"hd-radio-channel-program",
						"UHP"
					},
					{
 						"hd-radio-blend-mode",
						"UHB"
					},
					{
 						"hd-radio-tuner-status",
						"UHS"
					},
					{
 						"network-usb",
						"NTC"
					},
					{
 						"net-usb-artist-name-info",
						"NAT"
					},
					{
 						"net-usb-album-name-info",
						"NAL"
					},
					{
 						"net-usb-title-name",
						"NTI"
					},
					{
 						"net-usb-time-info",
						"NTM"
					},
					{
 						"net-usb-track-info",
						"NTR"
					},
					{
 						"net-usb-play-status",
						"NST"
					},
					{
 						"internet-radio-preset",
						"NPR"
					},
					{
 						"net-usb-list-info",
						"NLS"
					},
					{
 						"net-usb-jacket-art",
						"NJA"
					},
					{
 						"net-service",
						"NSV"
					},
					{
 						"net-keyboard",
						"NKY"
					},
					{
 						"net-popup-message",
						"NPU"
					},
					{
 						"ipod-mode-change",
						"IMD"
					},
					{
 						"cd-player",
						"CCD"
					},
					{
 						"tape1-a",
						"CT1"
					},
					{
 						"tape2-b",
						"CT2"
					},
					{
 						"graphics-equalizer",
						"CEQ"
					},
					{
 						"dat-recorder",
						"CDT"
					},
					{
 						"dvd-player",
						"CDV"
					},
					{
 						"md-recorder",
						"CMD"
					},
					{
 						"cd-r-recorder",
						"CCR"
					},
					{
 						"universal-port",
						"CPT"
					},
					{
 						"ipod-artist-name-info",
						"IAT"
					},
					{
 						"ipod-album-name-info",
						"IAL"
					},
					{
 						"ipod-title-name",
						"ITI"
					},
					{
 						"ipod-time-info",
						"ITM"
					},
					{
 						"ipod-track-info",
						"ITR"
					},
					{
 						"ipod-play-status",
						"IST"
					},
					{
 						"ipod-list-info",
						"ILS"
					},
					{
 						"dab-preset",
						"UPR"
					},
					{
 						"dab-sation-name",
						"UDS"
					},
					{
 						"dab-display-info",
						"UDD"
					}
				}
			},
			{
 				"zone2",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"power",
						"ZPW"
					},
					{
 						"muting",
						"ZMT"
					},
					{
 						"volume",
						"ZVL"
					},
					{
 						"tone",
						"ZTN"
					},
					{
 						"balance",
						"ZBL"
					},
					{
 						"selector",
						"SLZ"
					},
					{
 						"tuning",
						"TUZ"
					},
					{
 						"preset",
						"PRZ"
					},
					{
 						"net-tune-network",
						"NTZ"
					},
					{
 						"internet-radio-preset",
						"NPZ"
					},
					{
 						"listening-mode",
						"LMZ"
					},
					{
 						"late-night",
						"LTZ"
					},
					{
 						"re-eq-academy-filter",
						"RAZ"
					}
				}
			},
			{
 				"zone3",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"power",
						"PW3"
					},
					{
 						"muting",
						"MT3"
					},
					{
 						"volume",
						"VL3"
					},
					{
 						"tone",
						"TN3"
					},
					{
 						"balance",
						"BL3"
					},
					{
 						"selector",
						"SL3"
					},
					{
 						"tuning",
						"TU3"
					},
					{
 						"preset",
						"PR3"
					},
					{
 						"net-tune-network",
						"NT3"
					},
					{
 						"internet-radio-preset",
						"NP3"
					}
				}
			},
			{
 				"zone4",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"power",
						"PW4"
					},
					{
 						"muting",
						"MT4"
					},
					{
 						"volume",
						"VL4"
					},
					{
 						"selector",
						"SL4"
					},
					{
 						"tuning",
						"TU4"
					},
					{
 						"preset",
						"PR4"
					},
					{
 						"net-tune-network",
						"NT4"
					},
					{
 						"internet-radio-preset",
						"NP4"
					}
				}
			},
			{
 				"dock",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"command-for-docking-station-via-ri",
						"CDS"
					}
				}
			}
		};

		public static readonly OrderedDictionary ValueMappings = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
		{
			{
 				"main",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PWR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"standby",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"AMT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"toggle",
								"TG"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SPA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SPB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SPL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"surrback",
								"SB"
							},
							{
 								"front-high",
								"FH"
							},
							{
 								"surrback-front-high-speakers",
								"FH"
							},
							{
 								"front-wide",
								"FW"
							},
							{
 								"surrback-front-wide-speakers",
								"FW"
							},
							{
 								"front-high-front-wide-speakers",
								"HW"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"MVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"level-up",
								"UP"
							},
							{
 								"level-down",
								"DOWN"
							},
							{
 								"level-up-1db-step",
								"UP1"
							},
							{
 								"level-down-1db-step",
								"DOWN1"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TFR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TFW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TFH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TSR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TSB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TSW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLP",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"time-1-90min",
								new object[]
								{
									"1",
									"90"
								}
							},
							{
 								"time-off",
								"OFF"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"test",
								"TEST"
							},
							{
 								"chsel",
								"CHSEL"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							}
						}
					},
					{
 						"SWL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"15db-0db-12db",
								new object[]
								{
									"-15",
									"0",
									"12"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"CTL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"12db-0db-12db",
								new object[]
								{
									"-12",
									"0",
									"12"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"DIF",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"selector-volume",
								"00"
							},
							{
 								"selector-listening",
								"01"
							},
							{
 								"02",
								"02"
							},
							{
 								"03",
								"03"
							},
							{
 								"toggle",
								"TG"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"DIM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"bright",
								"00"
							},
							{
 								"dim",
								"DIM"
							},
							{
 								"dark",
								"02"
							},
							{
 								"shut-off",
								"03"
							},
							{
 								"bright-led-off",
								"08"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"OSD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"menu",
								"MENU"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"enter",
								"ENTER"
							},
							{
 								"exit",
								"EXIT"
							},
							{
 								"audio",
								"AUDIO"
							},
							{
 								"video",
								"VIDEO"
							},
							{
 								"home",
								"HOME"
							}
						}
					},
					{
 						"MEM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"str",
								"STR"
							},
							{
 								"rcl",
								"RCL"
							},
							{
 								"lock",
								"LOCK"
							},
							{
 								"unlk",
								"UNLK"
							}
						}
					},
					{
 						"IFA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"IFV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"video1",
								"00"
							},
							{
 								"vcr",
								"00"
							},
							{
 								"dvr",
								"00"
							},
							{
 								"video2",
								"01"
							},
							{
 								"cbl",
								"01"
							},
							{
 								"sat",
								"01"
							},
							{
 								"video3",
								"02"
							},
							{
 								"game",
								"02"
							},
							{
 								"tv",
								"23"
							},
							{
 								"video4",
								"03"
							},
							{
 								"aux1",
								"03"
							},
							{
 								"video5",
								"04"
							},
							{
 								"aux2",
								"04"
							},
							{
 								"video6",
								"05"
							},
							{
 								"pc",
								"05"
							},
							{
 								"video7",
								"06"
							},
							{
 								"07",
								"07"
							},
							{
 								"08",
								"08"
							},
							{
 								"09",
								"09"
							},
							{
 								"dvd",
								"10"
							},
							{
 								"bd",
								"10"
							},
							{
 								"tape-1",
								"20"
							},
							{
 								"tape",
								"20"
							},
							{
 								"tape2",
								"21"
							},
							{
 								"phono",
								"22"
							},
							{
 								"cd",
								"23"
							},
							{
 								"fm",
								"24"
							},
							{
 								"am",
								"25"
							},
							{
 								"tuner",
								"26"
							},
							{
 								"music-server",
								"27"
							},
							{
 								"p4s",
								"27"
							},
							{
 								"dlna",
								"27"
							},
							{
 								"internet-radio",
								"28"
							},
							{
 								"iradio-favorite",
								"28"
							},
							{
 								"usb",
								"2C"
							},
							{
 								"network",
								"2B"
							},
							{
 								"net",
								"2B"
							},
							{
 								"universal-port",
								"40"
							},
							{
 								"multi-ch",
								"30"
							},
							{
 								"xm",
								"31"
							},
							{
 								"sirius",
								"32"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"video1",
								"00"
							},
							{
 								"video2",
								"01"
							},
							{
 								"video3",
								"02"
							},
							{
 								"video4",
								"03"
							},
							{
 								"video5",
								"04"
							},
							{
 								"video6",
								"05"
							},
							{
 								"video7",
								"06"
							},
							{
 								"dvd",
								"10"
							},
							{
 								"tape",
								"20"
							},
							{
 								"tape2",
								"21"
							},
							{
 								"phono",
								"22"
							},
							{
 								"cd",
								"23"
							},
							{
 								"fm",
								"24"
							},
							{
 								"am",
								"25"
							},
							{
 								"tuner",
								"26"
							},
							{
 								"music-server",
								"27"
							},
							{
 								"internet-radio",
								"28"
							},
							{
 								"multi-ch",
								"30"
							},
							{
 								"xm",
								"31"
							},
							{
 								"off",
								"7F"
							},
							{
 								"source",
								"80"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"auto",
								"00"
							},
							{
 								"multi-channel",
								"01"
							},
							{
 								"analog",
								"02"
							},
							{
 								"ilink",
								"03"
							},
							{
 								"hdmi",
								"04"
							},
							{
 								"coax",
								"05"
							},
							{
 								"opt",
								"05"
							},
							{
 								"balance",
								"06"
							},
							{
 								"arc",
								"07"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TGA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							}
						}
					},
					{
 						"TGB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							}
						}
					},
					{
 						"TGC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							}
						}
					},
					{
 						"VOS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"d4",
								"00"
							},
							{
 								"component",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HDO",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no",
								"00"
							},
							{
 								"analog",
								"00"
							},
							{
 								"yes",
								"01"
							},
							{
 								"out",
								"01"
							},
							{
 								"out-sub",
								"02"
							},
							{
 								"sub",
								"02"
							},
							{
 								"both",
								"05"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HAO",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"auto",
								"02"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"RES",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"through",
								"00"
							},
							{
 								"auto",
								"01"
							},
							{
 								"480p",
								"02"
							},
							{
 								"720p",
								"03"
							},
							{
 								"1080i",
								"04"
							},
							{
 								"1080p",
								"07"
							},
							{
 								"24fs",
								"07"
							},
							{
 								"4k-upcaling",
								"08"
							},
							{
 								"source",
								"06"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ISF",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"custom",
								"00"
							},
							{
 								"day",
								"01"
							},
							{
 								"night",
								"02"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"VWM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"auto",
								"00"
							},
							{
 								"4-3",
								"01"
							},
							{
 								"full",
								"02"
							},
							{
 								"zoom",
								"04"
							},
							{
 								"smart-zoom",
								"05"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"VPM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"through",
								"00"
							},
							{
 								"custom",
								"01"
							},
							{
 								"cinema",
								"02"
							},
							{
 								"game",
								"03"
							},
							{
 								"isf-day",
								"05"
							},
							{
 								"isf-night",
								"06"
							},
							{
 								"streaming",
								"07"
							},
							{
 								"direct",
								"08"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"LMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"stereo",
								"00"
							},
							{
 								"direct",
								"01"
							},
							{
 								"surround",
								"02"
							},
							{
 								"film",
								"03"
							},
							{
 								"game-rpg",
								"03"
							},
							{
 								"thx",
								"04"
							},
							{
 								"action",
								"05"
							},
							{
 								"game-action",
								"05"
							},
							{
 								"musical",
								"06"
							},
							{
 								"game-rock",
								"06"
							},
							{
 								"mono-movie",
								"07"
							},
							{
 								"orchestra",
								"08"
							},
							{
 								"unplugged",
								"09"
							},
							{
 								"studio-mix",
								"0A"
							},
							{
 								"tv-logic",
								"0B"
							},
							{
 								"all-ch-stereo",
								"0C"
							},
							{
 								"theater-dimensional",
								"0D"
							},
							{
 								"enhanced-7",
								"0E"
							},
							{
 								"enhance",
								"0E"
							},
							{
 								"game-sports",
								"0E"
							},
							{
 								"mono",
								"0F"
							},
							{
 								"pure-audio",
								"11"
							},
							{
 								"multiplex",
								"12"
							},
							{
 								"full-mono",
								"13"
							},
							{
 								"dolby-virtual",
								"14"
							},
							{
 								"dts-surround-sensation",
								"15"
							},
							{
 								"audyssey-dsx",
								"16"
							},
							{
 								"whole-house",
								"1F"
							},
							{
 								"straight-decode",
								"40"
							},
							{
 								"dolby-ex",
								"41"
							},
							{
 								"thx-cinema",
								"42"
							},
							{
 								"thx-surround-ex",
								"43"
							},
							{
 								"thx-music",
								"44"
							},
							{
 								"thx-games",
								"52"
							},
							{
 								"thx-u2",
								"52"
							},
							{
 								"s2",
								"52"
							},
							{
 								"i",
								"52"
							},
							{
 								"s-cinema",
								"50"
							},
							{
 								"cinema2",
								"50"
							},
							{
 								"thx-musicmode",
								"51"
							},
							{
 								"s-music",
								"51"
							},
							{
 								"s-games",
								"52"
							},
							{
 								"plii",
								"8B"
							},
							{
 								"pliix-movie",
								"80"
							},
							{
 								"pliix-music",
								"81"
							},
							{
 								"neo-6-cinema",
								"82"
							},
							{
 								"neo-x-cinema",
								"82"
							},
							{
 								"neo-6-music",
								"83"
							},
							{
 								"neo-x-music",
								"83"
							},
							{
 								"pliix-thx-cinema",
								"84"
							},
							{
 								"neo-6",
								"8C"
							},
							{
 								"neo-x-thx-cinema",
								"85"
							},
							{
 								"pliix-game",
								"86"
							},
							{
 								"neural-surr",
								"87"
							},
							{
 								"neural-thx",
								"88"
							},
							{
 								"neural-surround",
								"88"
							},
							{
 								"pliix-thx-games",
								"89"
							},
							{
 								"neo-x-thx-games",
								"8A"
							},
							{
 								"pliix-thx-music",
								"8B"
							},
							{
 								"neo-x-thx-music",
								"8C"
							},
							{
 								"neural-thx-cinema",
								"8D"
							},
							{
 								"neural-thx-music",
								"8E"
							},
							{
 								"neural-thx-games",
								"8F"
							},
							{
 								"pliiz-height",
								"90"
							},
							{
 								"neo-6-cinema-dts-surround-sensation",
								"91"
							},
							{
 								"neo-6-music-dts-surround-sensation",
								"92"
							},
							{
 								"neural-digital-music",
								"93"
							},
							{
 								"pliiz-height-thx-cinema",
								"94"
							},
							{
 								"pliiz-height-thx-music",
								"95"
							},
							{
 								"pliiz-height-thx-games",
								"96"
							},
							{
 								"pliiz-height-thx-u2",
								"99"
							},
							{
 								"s2-cinema",
								"97"
							},
							{
 								"s2-music",
								"98"
							},
							{
 								"s2-games",
								"99"
							},
							{
 								"neo-x-game",
								"9A"
							},
							{
 								"pliix",
								"A2"
							},
							{
 								"plii-movie-audyssey-dsx",
								"A0"
							},
							{
 								"plii-music-audyssey-dsx",
								"A1"
							},
							{
 								"plii-game-audyssey-dsx",
								"A2"
							},
							{
 								"neo-6-cinema-audyssey-dsx",
								"A3"
							},
							{
 								"neo-6-music-audyssey-dsx",
								"A4"
							},
							{
 								"neural-surround-audyssey-dsx",
								"A5"
							},
							{
 								"neural-digital-music-audyssey-dsx",
								"A6"
							},
							{
 								"dolby-ex-audyssey-dsx",
								"A7"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"movie",
								"MOVIE"
							},
							{
 								"music",
								"MUSIC"
							},
							{
 								"game",
								"GAME"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"LTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"low-dolbydigital",
								"01"
							},
							{
 								"on-dolby-truehd",
								"01"
							},
							{
 								"high-dolbydigital",
								"02"
							},
							{
 								"auto-dolby-truehd",
								"03"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"RAS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ADY",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"movie",
								"01"
							},
							{
 								"music",
								"02"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ADQ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ADV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"light",
								"01"
							},
							{
 								"medium",
								"02"
							},
							{
 								"heavy",
								"03"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"DVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"low",
								"01"
							},
							{
 								"on",
								"01"
							},
							{
 								"mid",
								"02"
							},
							{
 								"high",
								"03"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"MOT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"direct",
								"DIRECT"
							},
							{
 								"0-in-direct-mode",
								"0"
							},
							{
 								"1-in-direct-mode",
								"1"
							},
							{
 								"2-in-direct-mode",
								"2"
							},
							{
 								"3-in-direct-mode",
								"3"
							},
							{
 								"4-in-direct-mode",
								"4"
							},
							{
 								"5-in-direct-mode",
								"5"
							},
							{
 								"6-in-direct-mode",
								"6"
							},
							{
 								"7-in-direct-mode",
								"7"
							},
							{
 								"8-in-direct-mode",
								"8"
							},
							{
 								"9-in-direct-mode",
								"9"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							}
						}
					},
					{
 						"RDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"00",
								"00"
							},
							{
 								"01",
								"01"
							},
							{
 								"02",
								"02"
							},
							{
 								"up",
								"UP"
							}
						}
					},
					{
 						"PTS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-0-30",
								new object[]
								{
									"0",
									"30"
								}
							},
							{
 								"enter",
								"ENTER"
							}
						}
					},
					{
 						"TPS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"enter",
								"ENTER"
							}
						}
					},
					{
 						"XCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"XAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"XTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"XCH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"XCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"STI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SCH",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SCT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLK",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"input",
								"INPUT"
							},
							{
 								"wrong",
								"WRONG"
							}
						}
					},
					{
 						"HAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HCN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"directly",
								new object[]
								{
									"1",
									"8"
								}
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HBL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"auto",
								"00"
							},
							{
 								"analog",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"HTS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"mmnnoo",
								"mmnnoo"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"trup",
								"TRUP"
							},
							{
 								"trdn",
								"TRDN"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"display",
								"DISPLAY"
							},
							{
 								"album",
								"ALBUM"
							},
							{
 								"artist",
								"ARTIST"
							},
							{
 								"genre",
								"GENRE"
							},
							{
 								"playlist",
								"PLAYLIST"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"select",
								"SELECT"
							},
							{
 								"0",
								"0"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"delete",
								"DELETE"
							},
							{
 								"caps",
								"CAPS"
							},
							{
 								"location",
								"LOCATION"
							},
							{
 								"language",
								"LANGUAGE"
							},
							{
 								"setup",
								"SETUP"
							},
							{
 								"return",
								"RETURN"
							},
							{
 								"chup",
								"CHUP"
							},
							{
 								"chdn",
								"CHDN"
							},
							{
 								"menu",
								"MENU"
							},
							{
 								"top",
								"TOP"
							},
							{
 								"mode",
								"MODE"
							},
							{
 								"list",
								"LIST"
							}
						}
					},
					{
 						"NAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NAL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"mm-ss-mm-ss",
								"mm:ss/mm:ss"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"cccc-tttt",
								"cccc/tttt"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NST",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"prs",
								"prs"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"set",
								"SET"
							}
						}
					},
					{
 						"NLS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"ti",
								"ti"
							}
						}
					},
					{
 						"NJA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"tp-xx-xx-xx-xx-xx-xx",
								"tp{xx}{xx}{xx}{xx}{xx}{xx}"
							}
						}
					},
					{
 						"NSV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{

						}
					},
					{
 						"NKY",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"ll",
								"ll"
							}
						}
					},
					{
 						"NPU",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{

						}
					},
					{
 						"NMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"std",
								"STD"
							},
							{
 								"ext",
								"EXT"
							},
							{
 								"vdc",
								"VDC"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"CCD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"power",
								"POWER"
							},
							{
 								"track",
								"TRACK"
							},
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"memory",
								"MEMORY"
							},
							{
 								"clear",
								"CLEAR"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"disp",
								"DISP"
							},
							{
 								"d-mode",
								"D.MODE"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"op-cl",
								"OP/CL"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"0",
								"0"
							},
							{
 								"10",
								"+10"
							},
							{
 								"d-skip",
								"D.SKIP"
							},
							{
 								"disc-f",
								"DISC.F"
							},
							{
 								"disc-r",
								"DISC.R"
							},
							{
 								"disc1",
								"DISC1"
							},
							{
 								"disc2",
								"DISC2"
							},
							{
 								"disc3",
								"DISC3"
							},
							{
 								"disc4",
								"DISC4"
							},
							{
 								"disc5",
								"DISC5"
							},
							{
 								"disc6",
								"DISC6"
							},
							{
 								"stby",
								"STBY"
							},
							{
 								"pon",
								"PON"
							}
						}
					},
					{
 						"CT1",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play-f",
								"PLAY.F"
							},
							{
 								"play-r",
								"PLAY.R"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"rc-pau",
								"RC/PAU"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							}
						}
					},
					{
 						"CT2",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play-f",
								"PLAY.F"
							},
							{
 								"play-r",
								"PLAY.R"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"rc-pau",
								"RC/PAU"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"op-cl",
								"OP/CL"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"rec",
								"REC"
							}
						}
					},
					{
 						"CEQ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"power",
								"POWER"
							},
							{
 								"preset",
								"PRESET"
							}
						}
					},
					{
 						"CDT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play",
								"PLAY"
							},
							{
 								"rc-pau",
								"RC/PAU"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							}
						}
					},
					{
 						"CDV",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"power",
								"POWER"
							},
							{
 								"pwron",
								"PWRON"
							},
							{
 								"pwroff",
								"PWROFF"
							},
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"lastplay",
								"LASTPLAY"
							},
							{
 								"subton-off",
								"SUBTON/OFF"
							},
							{
 								"subtitle",
								"SUBTITLE"
							},
							{
 								"setup",
								"SETUP"
							},
							{
 								"topmenu",
								"TOPMENU"
							},
							{
 								"menu",
								"MENU"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"enter",
								"ENTER"
							},
							{
 								"return",
								"RETURN"
							},
							{
 								"disc-f",
								"DISC.F"
							},
							{
 								"disc-r",
								"DISC.R"
							},
							{
 								"audio",
								"AUDIO"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"op-cl",
								"OP/CL"
							},
							{
 								"angle",
								"ANGLE"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"10",
								"10"
							},
							{
 								"0",
								"0"
							},
							{
 								"search",
								"SEARCH"
							},
							{
 								"disp",
								"DISP"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"memory",
								"MEMORY"
							},
							{
 								"clear",
								"CLEAR"
							},
							{
 								"abr",
								"ABR"
							},
							{
 								"step-f",
								"STEP.F"
							},
							{
 								"step-r",
								"STEP.R"
							},
							{
 								"slow-f",
								"SLOW.F"
							},
							{
 								"slow-r",
								"SLOW.R"
							},
							{
 								"zoomtg",
								"ZOOMTG"
							},
							{
 								"zoomup",
								"ZOOMUP"
							},
							{
 								"zoomdn",
								"ZOOMDN"
							},
							{
 								"progre",
								"PROGRE"
							},
							{
 								"vdoff",
								"VDOFF"
							},
							{
 								"conmem",
								"CONMEM"
							},
							{
 								"funmem",
								"FUNMEM"
							},
							{
 								"disc1",
								"DISC1"
							},
							{
 								"disc2",
								"DISC2"
							},
							{
 								"disc3",
								"DISC3"
							},
							{
 								"disc4",
								"DISC4"
							},
							{
 								"disc5",
								"DISC5"
							},
							{
 								"disc6",
								"DISC6"
							},
							{
 								"foldup",
								"FOLDUP"
							},
							{
 								"folddn",
								"FOLDDN"
							},
							{
 								"p-mode",
								"P.MODE"
							},
							{
 								"asctg",
								"ASCTG"
							},
							{
 								"cdpcd",
								"CDPCD"
							},
							{
 								"mspup",
								"MSPUP"
							},
							{
 								"mspdn",
								"MSPDN"
							},
							{
 								"pct",
								"PCT"
							},
							{
 								"rsctg",
								"RSCTG"
							},
							{
 								"init",
								"INIT"
							}
						}
					},
					{
 						"CMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"power",
								"POWER"
							},
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"p-mode",
								"P.MODE"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"rec",
								"REC"
							},
							{
 								"memory",
								"MEMORY"
							},
							{
 								"disp",
								"DISP"
							},
							{
 								"scroll",
								"SCROLL"
							},
							{
 								"m-scan",
								"M.SCAN"
							},
							{
 								"clear",
								"CLEAR"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"enter",
								"ENTER"
							},
							{
 								"eject",
								"EJECT"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"10-0",
								"10/0"
							},
							{
 								"name",
								"NAME"
							},
							{
 								"group",
								"GROUP"
							},
							{
 								"stby",
								"STBY"
							}
						}
					},
					{
 						"CCR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"power",
								"POWER"
							},
							{
 								"p-mode",
								"P.MODE"
							},
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"rec",
								"REC"
							},
							{
 								"clear",
								"CLEAR"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"10-0",
								"10/0"
							},
							{
 								"scroll",
								"SCROLL"
							},
							{
 								"op-cl",
								"OP/CL"
							},
							{
 								"disp",
								"DISP"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"memory",
								"MEMORY"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"stby",
								"STBY"
							}
						}
					},
					{
 						"CPT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"setup",
								"SETUP"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"enter",
								"ENTER"
							},
							{
 								"return",
								"RETURN"
							},
							{
 								"disp",
								"DISP"
							},
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"shuffle",
								"SHUFFLE"
							},
							{
 								"prsup",
								"PRSUP"
							},
							{
 								"prsdn",
								"PRSDN"
							},
							{
 								"0",
								"0"
							},
							{
 								"1",
								"1"
							},
							{
 								"2",
								"2"
							},
							{
 								"3",
								"3"
							},
							{
 								"4",
								"4"
							},
							{
 								"5",
								"5"
							},
							{
 								"6",
								"6"
							},
							{
 								"7",
								"7"
							},
							{
 								"8",
								"8"
							},
							{
 								"9",
								"9"
							},
							{
 								"10",
								"10"
							},
							{
 								"mode",
								"MODE"
							}
						}
					},
					{
 						"IAT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"IAL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ITI",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ITM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"mm-ss-mm-ss",
								"mm:ss/mm:ss"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ITR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"cccc-tttt",
								"cccc/tttt"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"IST",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"prs",
								"prs"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ILS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{

						}
					},
					{
 						"IMD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"std",
								"STD"
							},
							{
 								"ext",
								"EXT"
							},
							{
 								"vdc",
								"VDC"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UPR",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UPM",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{

						}
					},
					{
 						"UHP",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"directly",
								new object[]
								{
									"1",
									"8"
								}
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHB",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"auto",
								"00"
							},
							{
 								"analog",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHA",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UHS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"mmnnoo",
								"mmnnoo"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"UDD",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"pt",
								"PT"
							},
							{
 								"at",
								"AT"
							},
							{
 								"mn",
								"MN"
							},
							{
 								"mf",
								"MF"
							},
							{
 								"up",
								"UP"
							}
						}
					}
				}
			},
			{
 				"zone2",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"ZPW",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"standby",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ZMT",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"toggle",
								"TG"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ZVL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"level-up",
								"UP"
							},
							{
 								"level-down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ZTN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"bass-xx-is-a-00-a-10-0-10-2-step",
								"B{xx}"
							},
							{
 								"treble-xx-is-a-00-a-10-0-10-2-step",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"ZBL",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"xx-is-a-00-a-l-10-0-r-10-2-step",
								"{xx}"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SLZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"video1",
								"00"
							},
							{
 								"vcr",
								"00"
							},
							{
 								"dvr",
								"00"
							},
							{
 								"video2",
								"01"
							},
							{
 								"cbl",
								"01"
							},
							{
 								"sat",
								"01"
							},
							{
 								"video3",
								"02"
							},
							{
 								"game",
								"02"
							},
							{
 								"tv",
								"23"
							},
							{
 								"video4",
								"03"
							},
							{
 								"aux1",
								"03"
							},
							{
 								"video5",
								"04"
							},
							{
 								"aux2",
								"04"
							},
							{
 								"video6",
								"05"
							},
							{
 								"pc",
								"05"
							},
							{
 								"video7",
								"06"
							},
							{
 								"hidden1",
								"07"
							},
							{
 								"hidden2",
								"08"
							},
							{
 								"hidden3",
								"09"
							},
							{
 								"dvd",
								"10"
							},
							{
 								"bd",
								"10"
							},
							{
 								"tape",
								"20"
							},
							{
 								"tape2",
								"21"
							},
							{
 								"phono",
								"22"
							},
							{
 								"cd",
								"23"
							},
							{
 								"fm",
								"24"
							},
							{
 								"am",
								"25"
							},
							{
 								"tuner",
								"26"
							},
							{
 								"music-server",
								"27"
							},
							{
 								"p4s",
								"27"
							},
							{
 								"dlna",
								"27"
							},
							{
 								"internet-radio",
								"28"
							},
							{
 								"iradio-favorite",
								"28"
							},
							{
 								"usb",
								"2C"
							},
							{
 								"network",
								"2B"
							},
							{
 								"net",
								"2B"
							},
							{
 								"universal-port",
								"40"
							},
							{
 								"multi-ch",
								"30"
							},
							{
 								"xm",
								"31"
							},
							{
 								"sirius",
								"32"
							},
							{
 								"off",
								"7F"
							},
							{
 								"source",
								"80"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TUZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"direct",
								"DIRECT"
							},
							{
 								"0-in-direct-mode",
								"0"
							},
							{
 								"1-in-direct-mode",
								"1"
							},
							{
 								"2-in-direct-mode",
								"2"
							},
							{
 								"3-in-direct-mode",
								"3"
							},
							{
 								"4-in-direct-mode",
								"4"
							},
							{
 								"5-in-direct-mode",
								"5"
							},
							{
 								"6-in-direct-mode",
								"6"
							},
							{
 								"7-in-direct-mode",
								"7"
							},
							{
 								"8-in-direct-mode",
								"8"
							},
							{
 								"9-in-direct-mode",
								"9"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"playz",
								"PLAYz"
							},
							{
 								"stopz",
								"STOPz"
							},
							{
 								"pausez",
								"PAUSEz"
							},
							{
 								"trupz",
								"TRUPz"
							},
							{
 								"trdnz",
								"TRDNz"
							}
						}
					},
					{
 						"NTZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"trup",
								"TRUP"
							},
							{
 								"trdn",
								"TRDN"
							},
							{
 								"chup",
								"CHUP"
							},
							{
 								"chdn",
								"CHDN"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"display",
								"DISPLAY"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"select",
								"SELECT"
							},
							{
 								"return",
								"RETURN"
							}
						}
					},
					{
 						"NPZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							}
						}
					},
					{
 						"LMZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"stereo",
								"00"
							},
							{
 								"direct",
								"01"
							},
							{
 								"mono",
								"0F"
							},
							{
 								"multiplex",
								"12"
							},
							{
 								"dvs",
								"88"
							}
						}
					},
					{
 						"LTZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"low",
								"01"
							},
							{
 								"high",
								"02"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"RAZ",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"both-off",
								"00"
							},
							{
 								"on",
								"02"
							},
							{
 								"up",
								"UP"
							},
							{
 								"query",
								"QSTN"
							}
						}
					}
				}
			},
			{
 				"zone3",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PW3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"standby",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"MT3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"toggle",
								"TG"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"VL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"level-up",
								"UP"
							},
							{
 								"level-down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TN3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"b-xx",
								"B{xx}"
							},
							{
 								"t-xx",
								"T{xx}"
							},
							{
 								"bass-up",
								"BUP"
							},
							{
 								"bass-down",
								"BDOWN"
							},
							{
 								"treble-up",
								"TUP"
							},
							{
 								"treble-down",
								"TDOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"BL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"xx",
								"{xx}"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SL3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"video1",
								"00"
							},
							{
 								"vcr",
								"00"
							},
							{
 								"dvr",
								"00"
							},
							{
 								"video2",
								"01"
							},
							{
 								"cbl",
								"01"
							},
							{
 								"sat",
								"01"
							},
							{
 								"video3",
								"02"
							},
							{
 								"game",
								"02"
							},
							{
 								"tv",
								"23"
							},
							{
 								"video4",
								"03"
							},
							{
 								"aux1",
								"03"
							},
							{
 								"video5",
								"04"
							},
							{
 								"aux2",
								"04"
							},
							{
 								"video6",
								"05"
							},
							{
 								"pc",
								"05"
							},
							{
 								"video7",
								"06"
							},
							{
 								"hidden1",
								"07"
							},
							{
 								"hidden2",
								"08"
							},
							{
 								"hidden3",
								"09"
							},
							{
 								"dvd",
								"10"
							},
							{
 								"tape",
								"20"
							},
							{
 								"tape2",
								"21"
							},
							{
 								"phono",
								"22"
							},
							{
 								"cd",
								"23"
							},
							{
 								"fm",
								"24"
							},
							{
 								"am",
								"25"
							},
							{
 								"tuner",
								"26"
							},
							{
 								"music-server",
								"27"
							},
							{
 								"p4s",
								"27"
							},
							{
 								"dlna",
								"27"
							},
							{
 								"internet-radio",
								"28"
							},
							{
 								"iradio-favorite",
								"28"
							},
							{
 								"usb",
								"2C"
							},
							{
 								"network",
								"2B"
							},
							{
 								"net",
								"2B"
							},
							{
 								"universal-port",
								"40"
							},
							{
 								"multi-ch",
								"30"
							},
							{
 								"xm",
								"31"
							},
							{
 								"sirius",
								"32"
							},
							{
 								"source",
								"80"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TU3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"direct",
								"DIRECT"
							},
							{
 								"0-in-direct-mode",
								"0"
							},
							{
 								"1-in-direct-mode",
								"1"
							},
							{
 								"2-in-direct-mode",
								"2"
							},
							{
 								"3-in-direct-mode",
								"3"
							},
							{
 								"4-in-direct-mode",
								"4"
							},
							{
 								"5-in-direct-mode",
								"5"
							},
							{
 								"6-in-direct-mode",
								"6"
							},
							{
 								"7-in-direct-mode",
								"7"
							},
							{
 								"8-in-direct-mode",
								"8"
							},
							{
 								"9-in-direct-mode",
								"9"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PR3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"playz",
								"PLAYz"
							},
							{
 								"stopz",
								"STOPz"
							},
							{
 								"pausez",
								"PAUSEz"
							},
							{
 								"trupz",
								"TRUPz"
							},
							{
 								"trdnz",
								"TRDNz"
							}
						}
					},
					{
 						"NT3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"trup",
								"TRUP"
							},
							{
 								"trdn",
								"TRDN"
							},
							{
 								"chup",
								"CHUP"
							},
							{
 								"chdn",
								"CHDN"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"display",
								"DISPLAY"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"select",
								"SELECT"
							},
							{
 								"return",
								"RETURN"
							}
						}
					},
					{
 						"NP3",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							}
						}
					}
				}
			},
			{
 				"zone4",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"PW4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"standby",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"MT4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"off",
								"00"
							},
							{
 								"on",
								"01"
							},
							{
 								"toggle",
								"TG"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"VL4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"level-up",
								"UP"
							},
							{
 								"level-down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"SL4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"video1",
								"00"
							},
							{
 								"vcr",
								"00"
							},
							{
 								"dvr",
								"00"
							},
							{
 								"video2",
								"01"
							},
							{
 								"cbl",
								"01"
							},
							{
 								"sat",
								"01"
							},
							{
 								"video3",
								"02"
							},
							{
 								"game",
								"02"
							},
							{
 								"tv",
								"23"
							},
							{
 								"video4",
								"03"
							},
							{
 								"aux1",
								"03"
							},
							{
 								"video5",
								"04"
							},
							{
 								"aux2",
								"04"
							},
							{
 								"video6",
								"05"
							},
							{
 								"video7",
								"06"
							},
							{
 								"hidden1",
								"07"
							},
							{
 								"hidden2",
								"08"
							},
							{
 								"hidden3",
								"09"
							},
							{
 								"dvd",
								"10"
							},
							{
 								"tape-1",
								"20"
							},
							{
 								"tape",
								"20"
							},
							{
 								"tape2",
								"21"
							},
							{
 								"phono",
								"22"
							},
							{
 								"cd",
								"23"
							},
							{
 								"fm",
								"24"
							},
							{
 								"am",
								"25"
							},
							{
 								"tuner",
								"26"
							},
							{
 								"music-server",
								"27"
							},
							{
 								"p4s",
								"27"
							},
							{
 								"dlna",
								"27"
							},
							{
 								"internet-radio",
								"28"
							},
							{
 								"iradio-favorite",
								"28"
							},
							{
 								"usb",
								"2C"
							},
							{
 								"network",
								"2B"
							},
							{
 								"net",
								"2B"
							},
							{
 								"universal-port",
								"40"
							},
							{
 								"multi-ch",
								"30"
							},
							{
 								"xm",
								"31"
							},
							{
 								"sirius",
								"32"
							},
							{
 								"source",
								"80"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TUN",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"TU4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"direct",
								"DIRECT"
							},
							{
 								"0-in-direct-mode",
								"0"
							},
							{
 								"1-in-direct-mode",
								"1"
							},
							{
 								"2-in-direct-mode",
								"2"
							},
							{
 								"3-in-direct-mode",
								"3"
							},
							{
 								"4-in-direct-mode",
								"4"
							},
							{
 								"5-in-direct-mode",
								"5"
							},
							{
 								"6-in-direct-mode",
								"6"
							},
							{
 								"7-in-direct-mode",
								"7"
							},
							{
 								"8-in-direct-mode",
								"8"
							},
							{
 								"9-in-direct-mode",
								"9"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PRS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"PR4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							},
							{
 								"no-1-30",
								new object[]
								{
									"1",
									"30"
								}
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"query",
								"QSTN"
							}
						}
					},
					{
 						"NTC",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"playz",
								"PLAYz"
							},
							{
 								"stopz",
								"STOPz"
							},
							{
 								"pausez",
								"PAUSEz"
							},
							{
 								"trupz",
								"TRUPz"
							},
							{
 								"trdnz",
								"TRDNz"
							}
						}
					},
					{
 						"NT4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"play",
								"PLAY"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"trup",
								"TRUP"
							},
							{
 								"trdn",
								"TRDN"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"display",
								"DISPLAY"
							},
							{
 								"right",
								"RIGHT"
							},
							{
 								"left",
								"LEFT"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							},
							{
 								"select",
								"SELECT"
							},
							{
 								"return",
								"RETURN"
							}
						}
					},
					{
 						"NP4",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"no-1-40",
								new object[]
								{
									"1",
									"40"
								}
							}
						}
					}
				}
			},
			{
 				"dock",
				new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
				{
					{
 						"CDS",
						new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
						{
							{
 								"on",
								"PWRON"
							},
							{
 								"standby",
								"PWROFF"
							},
							{
 								"ply-res",
								"PLY/RES"
							},
							{
 								"stop",
								"STOP"
							},
							{
 								"skip-f",
								"SKIP.F"
							},
							{
 								"skip-r",
								"SKIP.R"
							},
							{
 								"pause",
								"PAUSE"
							},
							{
 								"ply-pau",
								"PLY/PAU"
							},
							{
 								"ff",
								"FF"
							},
							{
 								"rew",
								"REW"
							},
							{
 								"album",
								"ALBUM-"
							},
							{
 								"plist",
								"PLIST-"
							},
							{
 								"chapt",
								"CHAPT-"
							},
							{
 								"random",
								"RANDOM"
							},
							{
 								"repeat",
								"REPEAT"
							},
							{
 								"mute",
								"MUTE"
							},
							{
 								"blight",
								"BLIGHT"
							},
							{
 								"menu",
								"MENU"
							},
							{
 								"enter",
								"ENTER"
							},
							{
 								"up",
								"UP"
							},
							{
 								"down",
								"DOWN"
							}
						}
					}
				}
			}
		};
	}
}
