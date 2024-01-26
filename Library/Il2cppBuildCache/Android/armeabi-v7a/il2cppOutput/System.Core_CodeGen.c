#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000003 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000004 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000005 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000006 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000007 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000008 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000009 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000A System.Collections.Generic.Dictionary`2<TKey,TElement> System.Linq.Enumerable::ToDictionary(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>,System.Func`2<TSource,TElement>)
// 0x0000000B System.Collections.Generic.Dictionary`2<TKey,TElement> System.Linq.Enumerable::ToDictionary(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>,System.Func`2<TSource,TElement>,System.Collections.Generic.IEqualityComparer`1<TKey>)
// 0x0000000C TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000D TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000000E System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000010 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000012 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000013 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000014 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000015 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000016 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000017 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000018 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000019 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000001A System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000001B System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000001C System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000001D System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000001E System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001F System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000020 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000021 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000022 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000023 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000024 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000025 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000026 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000027 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000028 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000029 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002A System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x0000002B System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x0000002C System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002E System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000002F System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000030 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000031 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000032 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000033 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000034 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000035 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000036 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000037 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000038 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000039 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003A System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x0000003B System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x0000003C System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003D System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003E System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000003F System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000040 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000041 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000042 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000043 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000044 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000045 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000046 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000047 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000048 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000049 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x0000004A System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x0000004B System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x0000004C System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x0000004D System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x0000004E System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x0000004F System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000050 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000051 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000052 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000053 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x00000054 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000055 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000056 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000057 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000058 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000059 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x0000005A System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x0000005B System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x0000005C System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x0000005D System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x0000005E T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x0000005F System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000060 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[96] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[96] = 
{
	2049,
	2132,
	2132,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[33] = 
{
	{ 0x02000004, { 63, 4 } },
	{ 0x02000005, { 67, 9 } },
	{ 0x02000006, { 78, 7 } },
	{ 0x02000007, { 87, 10 } },
	{ 0x02000008, { 99, 11 } },
	{ 0x02000009, { 113, 9 } },
	{ 0x0200000A, { 125, 12 } },
	{ 0x0200000B, { 140, 1 } },
	{ 0x0200000C, { 141, 2 } },
	{ 0x0200000D, { 143, 4 } },
	{ 0x0200000E, { 147, 21 } },
	{ 0x02000010, { 168, 2 } },
	{ 0x06000004, { 0, 10 } },
	{ 0x06000005, { 10, 10 } },
	{ 0x06000006, { 20, 5 } },
	{ 0x06000007, { 25, 5 } },
	{ 0x06000008, { 30, 3 } },
	{ 0x06000009, { 33, 2 } },
	{ 0x0600000A, { 35, 1 } },
	{ 0x0600000B, { 36, 7 } },
	{ 0x0600000C, { 43, 4 } },
	{ 0x0600000D, { 47, 3 } },
	{ 0x0600000E, { 50, 1 } },
	{ 0x0600000F, { 51, 3 } },
	{ 0x06000010, { 54, 2 } },
	{ 0x06000011, { 56, 2 } },
	{ 0x06000012, { 58, 5 } },
	{ 0x06000022, { 76, 2 } },
	{ 0x06000027, { 85, 2 } },
	{ 0x0600002C, { 97, 2 } },
	{ 0x06000032, { 110, 3 } },
	{ 0x06000037, { 122, 3 } },
	{ 0x0600003C, { 137, 3 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[170] = 
{
	{ (Il2CppRGCTXDataType)2, 1099 },
	{ (Il2CppRGCTXDataType)3, 3425 },
	{ (Il2CppRGCTXDataType)2, 1798 },
	{ (Il2CppRGCTXDataType)2, 1510 },
	{ (Il2CppRGCTXDataType)3, 6201 },
	{ (Il2CppRGCTXDataType)2, 1167 },
	{ (Il2CppRGCTXDataType)2, 1517 },
	{ (Il2CppRGCTXDataType)3, 6224 },
	{ (Il2CppRGCTXDataType)2, 1512 },
	{ (Il2CppRGCTXDataType)3, 6208 },
	{ (Il2CppRGCTXDataType)2, 1100 },
	{ (Il2CppRGCTXDataType)3, 3426 },
	{ (Il2CppRGCTXDataType)2, 1809 },
	{ (Il2CppRGCTXDataType)2, 1519 },
	{ (Il2CppRGCTXDataType)3, 6231 },
	{ (Il2CppRGCTXDataType)2, 1181 },
	{ (Il2CppRGCTXDataType)2, 1527 },
	{ (Il2CppRGCTXDataType)3, 6259 },
	{ (Il2CppRGCTXDataType)2, 1523 },
	{ (Il2CppRGCTXDataType)3, 6244 },
	{ (Il2CppRGCTXDataType)2, 414 },
	{ (Il2CppRGCTXDataType)3, 14 },
	{ (Il2CppRGCTXDataType)3, 15 },
	{ (Il2CppRGCTXDataType)2, 698 },
	{ (Il2CppRGCTXDataType)3, 2548 },
	{ (Il2CppRGCTXDataType)2, 415 },
	{ (Il2CppRGCTXDataType)3, 20 },
	{ (Il2CppRGCTXDataType)3, 21 },
	{ (Il2CppRGCTXDataType)2, 706 },
	{ (Il2CppRGCTXDataType)3, 2552 },
	{ (Il2CppRGCTXDataType)2, 460 },
	{ (Il2CppRGCTXDataType)3, 443 },
	{ (Il2CppRGCTXDataType)3, 444 },
	{ (Il2CppRGCTXDataType)2, 1168 },
	{ (Il2CppRGCTXDataType)3, 3800 },
	{ (Il2CppRGCTXDataType)3, 7427 },
	{ (Il2CppRGCTXDataType)2, 527 },
	{ (Il2CppRGCTXDataType)3, 826 },
	{ (Il2CppRGCTXDataType)2, 871 },
	{ (Il2CppRGCTXDataType)2, 918 },
	{ (Il2CppRGCTXDataType)3, 2550 },
	{ (Il2CppRGCTXDataType)3, 2551 },
	{ (Il2CppRGCTXDataType)3, 827 },
	{ (Il2CppRGCTXDataType)2, 1046 },
	{ (Il2CppRGCTXDataType)2, 783 },
	{ (Il2CppRGCTXDataType)2, 859 },
	{ (Il2CppRGCTXDataType)2, 916 },
	{ (Il2CppRGCTXDataType)2, 860 },
	{ (Il2CppRGCTXDataType)2, 917 },
	{ (Il2CppRGCTXDataType)3, 2549 },
	{ (Il2CppRGCTXDataType)2, 852 },
	{ (Il2CppRGCTXDataType)2, 853 },
	{ (Il2CppRGCTXDataType)2, 914 },
	{ (Il2CppRGCTXDataType)3, 2547 },
	{ (Il2CppRGCTXDataType)2, 782 },
	{ (Il2CppRGCTXDataType)2, 858 },
	{ (Il2CppRGCTXDataType)2, 781 },
	{ (Il2CppRGCTXDataType)3, 7411 },
	{ (Il2CppRGCTXDataType)3, 2220 },
	{ (Il2CppRGCTXDataType)2, 624 },
	{ (Il2CppRGCTXDataType)2, 855 },
	{ (Il2CppRGCTXDataType)2, 915 },
	{ (Il2CppRGCTXDataType)2, 963 },
	{ (Il2CppRGCTXDataType)3, 3427 },
	{ (Il2CppRGCTXDataType)3, 3429 },
	{ (Il2CppRGCTXDataType)2, 294 },
	{ (Il2CppRGCTXDataType)3, 3428 },
	{ (Il2CppRGCTXDataType)3, 3437 },
	{ (Il2CppRGCTXDataType)2, 1103 },
	{ (Il2CppRGCTXDataType)2, 1513 },
	{ (Il2CppRGCTXDataType)3, 6209 },
	{ (Il2CppRGCTXDataType)3, 3438 },
	{ (Il2CppRGCTXDataType)2, 889 },
	{ (Il2CppRGCTXDataType)2, 935 },
	{ (Il2CppRGCTXDataType)3, 2557 },
	{ (Il2CppRGCTXDataType)3, 7401 },
	{ (Il2CppRGCTXDataType)2, 1524 },
	{ (Il2CppRGCTXDataType)3, 6245 },
	{ (Il2CppRGCTXDataType)3, 3430 },
	{ (Il2CppRGCTXDataType)2, 1102 },
	{ (Il2CppRGCTXDataType)2, 1511 },
	{ (Il2CppRGCTXDataType)3, 6202 },
	{ (Il2CppRGCTXDataType)3, 2556 },
	{ (Il2CppRGCTXDataType)3, 3431 },
	{ (Il2CppRGCTXDataType)3, 7400 },
	{ (Il2CppRGCTXDataType)2, 1520 },
	{ (Il2CppRGCTXDataType)3, 6232 },
	{ (Il2CppRGCTXDataType)3, 3444 },
	{ (Il2CppRGCTXDataType)2, 1104 },
	{ (Il2CppRGCTXDataType)2, 1518 },
	{ (Il2CppRGCTXDataType)3, 6225 },
	{ (Il2CppRGCTXDataType)3, 3837 },
	{ (Il2CppRGCTXDataType)3, 1783 },
	{ (Il2CppRGCTXDataType)3, 2558 },
	{ (Il2CppRGCTXDataType)3, 1782 },
	{ (Il2CppRGCTXDataType)3, 3445 },
	{ (Il2CppRGCTXDataType)3, 7402 },
	{ (Il2CppRGCTXDataType)2, 1528 },
	{ (Il2CppRGCTXDataType)3, 6260 },
	{ (Il2CppRGCTXDataType)3, 3458 },
	{ (Il2CppRGCTXDataType)2, 1106 },
	{ (Il2CppRGCTXDataType)2, 1526 },
	{ (Il2CppRGCTXDataType)3, 6247 },
	{ (Il2CppRGCTXDataType)3, 3459 },
	{ (Il2CppRGCTXDataType)2, 892 },
	{ (Il2CppRGCTXDataType)2, 938 },
	{ (Il2CppRGCTXDataType)3, 2562 },
	{ (Il2CppRGCTXDataType)3, 2561 },
	{ (Il2CppRGCTXDataType)2, 1515 },
	{ (Il2CppRGCTXDataType)3, 6211 },
	{ (Il2CppRGCTXDataType)3, 7406 },
	{ (Il2CppRGCTXDataType)2, 1525 },
	{ (Il2CppRGCTXDataType)3, 6246 },
	{ (Il2CppRGCTXDataType)3, 3451 },
	{ (Il2CppRGCTXDataType)2, 1105 },
	{ (Il2CppRGCTXDataType)2, 1522 },
	{ (Il2CppRGCTXDataType)3, 6234 },
	{ (Il2CppRGCTXDataType)3, 2560 },
	{ (Il2CppRGCTXDataType)3, 2559 },
	{ (Il2CppRGCTXDataType)3, 3452 },
	{ (Il2CppRGCTXDataType)2, 1514 },
	{ (Il2CppRGCTXDataType)3, 6210 },
	{ (Il2CppRGCTXDataType)3, 7405 },
	{ (Il2CppRGCTXDataType)2, 1521 },
	{ (Il2CppRGCTXDataType)3, 6233 },
	{ (Il2CppRGCTXDataType)3, 3465 },
	{ (Il2CppRGCTXDataType)2, 1107 },
	{ (Il2CppRGCTXDataType)2, 1530 },
	{ (Il2CppRGCTXDataType)3, 6262 },
	{ (Il2CppRGCTXDataType)3, 3838 },
	{ (Il2CppRGCTXDataType)3, 1785 },
	{ (Il2CppRGCTXDataType)3, 2564 },
	{ (Il2CppRGCTXDataType)3, 2563 },
	{ (Il2CppRGCTXDataType)3, 1784 },
	{ (Il2CppRGCTXDataType)3, 3466 },
	{ (Il2CppRGCTXDataType)2, 1516 },
	{ (Il2CppRGCTXDataType)3, 6212 },
	{ (Il2CppRGCTXDataType)3, 7407 },
	{ (Il2CppRGCTXDataType)2, 1529 },
	{ (Il2CppRGCTXDataType)3, 6261 },
	{ (Il2CppRGCTXDataType)3, 2554 },
	{ (Il2CppRGCTXDataType)3, 2555 },
	{ (Il2CppRGCTXDataType)3, 2565 },
	{ (Il2CppRGCTXDataType)2, 784 },
	{ (Il2CppRGCTXDataType)2, 1812 },
	{ (Il2CppRGCTXDataType)2, 872 },
	{ (Il2CppRGCTXDataType)2, 919 },
	{ (Il2CppRGCTXDataType)3, 2236 },
	{ (Il2CppRGCTXDataType)2, 632 },
	{ (Il2CppRGCTXDataType)3, 2755 },
	{ (Il2CppRGCTXDataType)3, 2756 },
	{ (Il2CppRGCTXDataType)3, 2761 },
	{ (Il2CppRGCTXDataType)2, 971 },
	{ (Il2CppRGCTXDataType)3, 2758 },
	{ (Il2CppRGCTXDataType)3, 7621 },
	{ (Il2CppRGCTXDataType)2, 611 },
	{ (Il2CppRGCTXDataType)3, 1777 },
	{ (Il2CppRGCTXDataType)1, 841 },
	{ (Il2CppRGCTXDataType)2, 1818 },
	{ (Il2CppRGCTXDataType)3, 2757 },
	{ (Il2CppRGCTXDataType)1, 1818 },
	{ (Il2CppRGCTXDataType)1, 971 },
	{ (Il2CppRGCTXDataType)2, 1859 },
	{ (Il2CppRGCTXDataType)2, 1818 },
	{ (Il2CppRGCTXDataType)3, 2762 },
	{ (Il2CppRGCTXDataType)3, 2760 },
	{ (Il2CppRGCTXDataType)3, 2759 },
	{ (Il2CppRGCTXDataType)2, 210 },
	{ (Il2CppRGCTXDataType)3, 1786 },
	{ (Il2CppRGCTXDataType)2, 303 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	96,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	33,
	s_rgctxIndices,
	170,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
