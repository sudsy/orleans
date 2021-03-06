﻿using Orleans;
using System.Collections;
using System.Collections.Generic;


namespace UnitTests.StorageTests.Relational.TestingDataSets
{
    public class StorageDataSetMixed1<TGrainKey1, TGrainKey2>: IEnumerable<object[]>
    {
        private IEnumerable<object[]> DataSet { get; } = new[]
        {
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey1>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data1", B = 1, C = 4 } }
            },
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey1>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data2", B = 2, C = 5 } }
            },
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey1>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data3", B = 3, C = 6 } }
            },
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey2>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data1", B = 1, C = 4 } }
            },
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey2>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data2", B = 2, C = 5 } }
            },
            new object[]
            {
                RandomUtilities.GetRandomGrainReference<TGrainKey2>(),
                new GrainState<TestState1> { State = new TestState1 { A = "Data3", B = 3, C = 6 } }
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return DataSet.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
