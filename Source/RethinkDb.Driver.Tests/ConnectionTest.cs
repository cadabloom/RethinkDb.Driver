﻿using System;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RethinkDb.Driver.Net;
using System.Linq;
using Templates.Utils;

namespace RethinkDb.Driver.Tests
{
    [TestFixture]
    public class ConnectionTest
    {
        private const string DbName = "CSharpDriverTests";
        private const string TableName = "TableA";

        public static RethinkDB r = RethinkDB.r;

        private Connection conn;

        private void EnsureConnection()
        {
            if( conn == null )
            {
                this.conn = r.connection()
                    .hostname("192.168.0.11")
                    .port(RethinkDBConstants.DEFAULT_PORT)
                    .connect();
            }
        }

        [TestFixtureSetUp]
        public void BeforeRunningTestSession()
        {
            EnsureConnection();
            //try
            //{
            //    r.dbCreate(DbName).run(conn);

            //    r.db(DbName).wait_().run(conn);
            //    r.db(DbName).tableCreate(TableName).run(conn);
            //    r.db(DbName).table(TableName).wait_().run(conn);
            //}
            //catch
            //{
            //}
        }

        [TestFixtureTearDown]
        public void AfterRunningTestSession()
        {
            //try
            //{
            //    r.db(DbName).tableDrop(TableName).run(conn);
            //    r.dbDrop(DbName).run(conn);
            //    conn.close();
            //}
            //catch { }
        }

        [Test]
        [Explicit]
        public void create_table()
        {
            r.dbCreate(DbName).run(conn);

            r.db(DbName).wait_().run(conn);
            r.db(DbName).tableCreate(TableName).run(conn);
            r.db(DbName).table(TableName).wait_().run(conn);
        }

        [Test]
        [Explicit]
        public void delete_table()
        {
            r.db(DbName).tableDrop(TableName).run(conn);
            r.dbDrop(DbName).run(conn);
            conn.close();
        }

        [Test]
        public void can_connect()
        {
            var c = r.connection()
                .hostname("192.168.0.11")
                .port(RethinkDBConstants.DEFAULT_PORT)
                .timeout(60)
                .connect();

            var result = r.random(1, 9).add(r.random(1, 9)).run<int>(c);
            Console.WriteLine(result);
            result.Should().BeGreaterOrEqualTo(2).And.BeLessThan(18);
        }

        [Test]
        public void test_booleans()
        {
            bool t = r.expr(true).run<bool>(conn);
            t.Should().Be(true);
        }

        [Test]
        public void test_time_pesudo_type()
        {
            var t = r.now().run<DateTimeOffset>(conn);
            //ten minute limit for clock drift.
            t.Should().BeCloseTo(DateTimeOffset.UtcNow, 600000);
        }

        [Test]
        public void test_jvalue()
        {
            var t = r.now().run<JValue>(conn);
            //ten minute limit for clock drift.
            t.Dump();
        }
        
    }

}