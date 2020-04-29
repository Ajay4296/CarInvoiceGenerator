import React from 'react'

export class Navigation extends React.Component {

    onChange = (e) => {
        this.props.history.push(`/${e.target.value}`);
      }

    render() {
        return (
            <div>
                
                <select className="SelectOption" onChange={this.onChange}>
                    <option to='/Length'> Length</option>
                    <option to='/Weight' > Weight</option>
                    <option to='/Temprature'> Temprature</option>
                    
                </select>
                
            </div>
        )
    }
}
export default Navigation;