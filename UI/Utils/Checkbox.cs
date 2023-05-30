using Sandbox.UI.Construct;

namespace Discord.UI.Utils;

[Library( "checkbox" )]
public class Checkbox : Panel
{
	/// <summary>
	/// Called when the value has been changed
	/// </summary>
	public Action<bool> ValueChanged { get; set; }

	/// <summary>
	/// The checkmark icon. Although no guarantees it's an icon!
	/// </summary>
	public Panel CheckMark { get; protected set; }

	protected bool isChecked = false;
	public bool Checked
	{
		get => isChecked;
		set
		{
			if ( isChecked == value )
				return;

			isChecked = value;
			OnValueChanged();
		}
	}

	public Checkbox()
	{
		CheckMark = Add.Icon( "check", "checkmark" );
	}

	public override void SetProperty( string name, string value )
	{
		base.SetProperty( name, value );

		if ( name == "checked" || name == "value" )
		{
			Checked = value.ToBool();
		}
	}

	public virtual void OnValueChanged()
	{
		UpdateState();
		CreateEvent( "onchange", Checked );

		if ( Checked )
		{
			CreateEvent( "onchecked" );
		}
		else
		{
			CreateEvent( "onunchecked" );
		}
	}

	protected virtual void UpdateState()
	{
		SetClass( "checked", Checked );
	}

	protected override void OnClick( MousePanelEvent e )
	{
		base.OnClick( e );

		Checked = !Checked;
		CreateValueEvent( "checked", Checked );
		CreateValueEvent( "value", Checked );
		e.StopPropagation();

		ValueChanged?.Invoke( Checked );
	}
}
