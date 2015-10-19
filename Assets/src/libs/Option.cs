using System;
using System.Collections.Generic;

namespace Libs {

    static public class Option {
        static public Option<T> empty<T>() {
            return new None<T>();
        }

        static public Option<T> some<T>(T val) {
            return new Some<T>(val);
        }
    }

    abstract public class Option<T> {

        abstract public bool isEmpty {
            get;
        }

        public bool nonEmpty {
            get { return !isEmpty; }
        }

        abstract public T get {
            get;
        }

        abstract public Option<T> orElse(Func<Option<T>> alternative);

        abstract public Option<T> orElse(Option<T> alternative);

        abstract public T getOrElse(T defaultValue);

        abstract public T getOrElse(Func<T> procedure);

        abstract public S fold<S>(S defaultValue, Func<T,S> reducer);

        abstract public Option<S> map<S>(Func<T, S> mapper);

        abstract public Option<S> flatMap<S>(Func<T, Option<S>> mapper);

        abstract public void forEach(Action<T> procedure);

        abstract public bool exists(Func<T, bool> filter);

        static public List<T> operator+ (Option<T> one, Option<T> other) {
            var list = new List<T>();

            one.forEach(e => list.Add(e));
            other.forEach(e => list.Add(e));

            return list;
        }

        static public List<T> operator+ (List<T> list, Option<T> one) {
            if(one.isEmpty) {
                return list;
            }

            var l2 = new List<T>(list);
            one.forEach(e => l2.Add(e));

            return l2;
        }
    }

    public sealed class None<T> : Option<T> {
        public None() : base() { }

        public override bool isEmpty {
            get { return true; }
        }

        public override T get {
            get {
				throw new InvalidOperationException("invoke get with empty content");
            }
        }

        public override Option<T> orElse(Option<T> alternative) {
            return alternative;
        }

        public override Option<T> orElse(Func<Option<T>> alternative) {
            return alternative();
        }

        public override T getOrElse(T defaultValue) {
            return defaultValue;
        }

        public override T getOrElse(Func<T> procedure) {
            return procedure();
        }

        public override S fold<S>(S defaultValue, Func<T,S> reducer) {
            return defaultValue;
        }

        public override Option<S> flatMap<S>(Func<T, Option<S>> mapper) {
            return new None<S>();
        }

        public override Option<S> map<S>(Func<T, S> mapper) {
            return new None<S>();
        }

        public override void forEach(Action<T> procedure) {
            // nothing
        }

        public override bool exists(Func<T, bool> filter) {
            return false;
        }

        public override string ToString() {
            return "None";
        }
    }

    public sealed class Some<T> : Option<T> {
        private T val;

        public Some(T val) : base() {
            this.val = val;
        }

        public override bool isEmpty {
            get { return false; }
        }

        public override T get {
            get { return val; }
        }

        public override Option<T> orElse(Option<T> alternative) {
            return this;
        }

        public override Option<T> orElse(Func<Option<T>> alternative) {
            return this;
        }

        public override T getOrElse(T defaultValue) {
            return val;
        }

        public override T getOrElse(Func<T> procedure) {
            return val;
        }

        public override S fold<S>(S defaultValue, Func<T,S> reducer) {
            return reducer(val);
        }

        public override Option<S> flatMap<S>(Func<T, Option<S>> mapper) {
            return mapper(val);
        }

        public override Option<S> map<S>(Func<T, S> mapper) {
            var s = mapper(val);
            return Option.some(s);
        }

        public override void forEach(Action<T> action) {
            action(val);
        }

        public override bool exists(Func<T, bool> filter) {
            return filter(val);
        }

        public override string ToString() {
            return string.Format("[Some: get={0}]", get);
        }
    }

}

