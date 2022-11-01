# FormTableGenerator
This is the UI desktop application aimed at creating tables with DAC digital values for embedded systems

## TODO
1. Set resolution value. For exapmle: 12 bit, then maximum digital value = 0xFFF
2. Set samples qty. Consider that the more samples the more ideal form you will get,
but then you also have to use timer with higher frequency to get the same frequency of the signal:
`Signal freq = timer freq/samples`
3. Set desired number of rows. Pay attention, that this is also the way to calculate
values amount in the one row. So you can use only integer values of dividing result

## Example 1
* Setting:

![10 Samples DataSetup](https://github.com/FT9R/FormTableGenerator/blob/master/Images/10%20Samples/DataSetup.png) 
* Table:
```
const uint16_t Sin_12bit[10] =
{
2047,3250,3994,3994,3250,
2047,844,100,100,844
};
```
* Waveform

![10 Samples Waveform](https://github.com/FT9R/FormTableGenerator/blob/master/Images/10%20Samples/Waveform.png) 

## Example 2
* Setting:

![128 Samples DataSetup](https://github.com/FT9R/FormTableGenerator/blob/master/Images/128%20Samples/DataSetup.png) 
* Table:
```
const uint16_t Sin_12bit[128] =
{
2047,2147,2248,2347,2446,2544,2641,2737,2830,2922,3012,3099,3184,3266,3346,3422,
3494,3564,3629,3691,3749,3803,3852,3897,3938,3974,4006,4033,4055,4072,4084,4092,
4094,4092,4084,4072,4055,4033,4006,3974,3938,3897,3852,3803,3749,3691,3629,3564,
3494,3422,3346,3266,3184,3099,3012,2922,2830,2737,2641,2544,2446,2347,2248,2147,
2047,1947,1846,1747,1648,1550,1453,1357,1264,1172,1082,995,910,828,748,672,
600,530,465,403,345,291,242,197,156,120,88,61,39,22,10,2,
0,2,10,22,39,61,88,120,156,197,242,291,345,403,465,530,
600,672,748,828,910,995,1082,1172,1264,1357,1453,1550,1648,1747,1846,1947
};
```
* Waveform

![128 Samples Waveform](https://github.com/FT9R/FormTableGenerator/blob/master/Images/128%20Samples/Waveform.png) 
