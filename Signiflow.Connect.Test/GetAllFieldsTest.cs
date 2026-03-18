using Newtonsoft.Json;
using SigniFlow.Connect.Model;

namespace Signiflow.Connect.Test;

[TestFixture]
public class GetAllFieldsTests
{
    private DateTime _testDate;

    [SetUp]
    public void Setup()
    {
        _testDate = new DateTime(2025, 6, 15, 10, 30, 0);
    }

    [Test(Description = "PrepperFieldValuesField constructor stores DateTimeField")]
    public void PrepperFieldValuesField_Constructor_StoresDateTimeField()
    {
        var field = new PrepperFieldValuesField(
            docIDField: 100,
            fieldNameField: "Signature1",
            fieldTypeField: "Signature",
            fieldValueField: "",
            heightField: "50",
            pageNumberField: 1,
            prepperFieldIDField: 42,
            userFullNameField: "John Doe",
            userIDField: 7,
            widthField: "200",
            xCoordinateField: "100",
            yCoordinateField: "300",
            dateTimeField: _testDate);

        Assert.That(field.DateTimeField, Is.EqualTo(_testDate));
    }

    [Test(Description = "PrepperFieldValuesField defaults DateTimeField to DateTime.MinValue")]
    public void PrepperFieldValuesField_DefaultConstructor_DateTimeFieldIsDefault()
    {
        var field = new PrepperFieldValuesField();

        Assert.That(field.DateTimeField, Is.EqualTo(default(DateTime)));
    }

    [Test(Description = "DateTimeField round-trips through JSON serialization with correct property name")]
    public void PrepperFieldValuesField_JsonRoundTrip_PreservesDateTimeField()
    {
        var original = new PrepperFieldValuesField(
            docIDField: 100,
            fieldNameField: "TestField",
            fieldTypeField: "Signature",
            fieldValueField: "",
            heightField: "50",
            pageNumberField: 1,
            prepperFieldIDField: 42,
            userFullNameField: "John Doe",
            userIDField: 7,
            widthField: "200",
            xCoordinateField: "100",
            yCoordinateField: "300",
            dateTimeField: _testDate);

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<PrepperFieldValuesField>(json);

        Assert.That(deserialized, Is.Not.Null);
        Assert.That(deserialized!.DateTimeField, Is.EqualTo(_testDate));
    }

    [Test(Description = "DateTimeField serializes with PascalCase property name 'DateTimeField'")]
    public void PrepperFieldValuesField_Serialization_UsesPascalCaseName()
    {
        var field = new PrepperFieldValuesField(dateTimeField: _testDate);

        var json = field.ToJson();

        Assert.That(json, Does.Contain("\"DateTimeField\""));
        Assert.That(json, Does.Not.Contain("\"dateTimeField\""));
    }

    [Test(Description = "Two PrepperFieldValuesField with same DateTimeField are equal")]
    public void PrepperFieldValuesField_Equals_IncludesDateTimeField()
    {
        var field1 = new PrepperFieldValuesField(docIDField: 1, dateTimeField: _testDate);
        var field2 = new PrepperFieldValuesField(docIDField: 1, dateTimeField: _testDate);

        Assert.That(field1.Equals(field2), Is.True);
    }

    [Test(Description = "Two PrepperFieldValuesField with different DateTimeField are not equal")]
    public void PrepperFieldValuesField_NotEquals_WhenDateTimeFieldDiffers()
    {
        var field1 = new PrepperFieldValuesField(docIDField: 1, dateTimeField: _testDate);
        var field2 = new PrepperFieldValuesField(docIDField: 1, dateTimeField: _testDate.AddDays(1));

        Assert.That(field1.Equals(field2), Is.False);
    }

    [Test(Description = "DocPrepperGetAllFieldsResponse includes DateTimeField in each prepper field")]
    public void DocPrepperGetAllFieldsResponse_ContainsDateTimeInFields()
    {
        var fields = new List<PrepperFieldValuesField>
        {
            new PrepperFieldValuesField(docIDField: 1, fieldTypeField: "Signature", dateTimeField: _testDate),
            new PrepperFieldValuesField(docIDField: 1, fieldTypeField: "NameText", dateTimeField: _testDate.AddHours(2))
        };

        var response = new DocPrepperGetAllFieldsResponse(
            resultField: "Success",
            prepperFieldValuesField: fields);

        Assert.That(response.ResultField, Is.EqualTo("Success"));
        Assert.That(response.PrepperFieldValuesField, Has.Count.EqualTo(2));
        Assert.That(response.PrepperFieldValuesField[0].DateTimeField, Is.EqualTo(_testDate));
        Assert.That(response.PrepperFieldValuesField[1].DateTimeField, Is.EqualTo(_testDate.AddHours(2)));
    }

    [Test(Description = "DocPrepperGetAllFieldsResponse round-trips through JSON with DateTimeField intact")]
    public void DocPrepperGetAllFieldsResponse_JsonRoundTrip_PreservesDateTimeFields()
    {
        var fields = new List<PrepperFieldValuesField>
        {
            new PrepperFieldValuesField(
                docIDField: 200,
                fieldNameField: "Sig1",
                fieldTypeField: "Signature",
                fieldValueField: "",
                heightField: "40",
                pageNumberField: 1,
                prepperFieldIDField: 10,
                userFullNameField: "Jane Smith",
                userIDField: 3,
                widthField: "150",
                xCoordinateField: "50",
                yCoordinateField: "600",
                dateTimeField: _testDate)
        };

        var original = new DocPrepperGetAllFieldsResponse(
            resultField: "Success",
            prepperFieldValuesField: fields);

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<DocPrepperGetAllFieldsResponse>(json);

        Assert.That(deserialized, Is.Not.Null);
        Assert.That(deserialized!.PrepperFieldValuesField, Has.Count.EqualTo(1));
        Assert.That(deserialized.PrepperFieldValuesField[0].DateTimeField, Is.EqualTo(_testDate));
    }

    [Test(Description = "ToString includes DateTimeField")]
    public void PrepperFieldValuesField_ToString_IncludesDateTimeField()
    {
        var field = new PrepperFieldValuesField(dateTimeField: _testDate);

        var result = field.ToString();

        Assert.That(result, Does.Contain("DateTimeField"));
        Assert.That(result, Does.Contain(_testDate.ToString()));
    }
}
